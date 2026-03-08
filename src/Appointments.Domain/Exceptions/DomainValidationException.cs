using Appointments.Domain.Exceptions.Base;

namespace Appointments.Domain.Exceptions;

public class DomainValidationException(string message, string propertyName = "") : DomainException(message)
{
    public string PropertyName { get; } = propertyName;
}