using Appointments.Domain.Common;
using Appointments.Domain.Exceptions;

namespace Appointments.Domain.Entities;

public class Client : BaseEntity
{
    public string Name { get; private init; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; } = string.Empty;
    public DateTime DateOfBirth { get; private init; }

    public Client(string name, string email, DateTime dateOfBirth)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainValidationException("Name is required", nameof(Name));

        if (string.IsNullOrWhiteSpace(email))
            throw new DomainValidationException("Email is required", nameof(Email));

        if (dateOfBirth > DateTime.Now)
            throw new DomainValidationException("Date of birth cannot be in the future", nameof(DateOfBirth));

        if (dateOfBirth > DateTime.Now.AddYears(-5))
            throw new DomainValidationException("Client must be at least five years old", nameof(DateOfBirth));

        Name = name;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void UpdateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new DomainValidationException("Email is required", nameof(Email));

        Email = email;
    }
}