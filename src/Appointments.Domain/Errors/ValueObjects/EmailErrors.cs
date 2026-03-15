using Appointments.Domain.Shared;

namespace Appointments.Domain.Errors.ValueObjects;

public static class EmailErrors
{
    public static readonly Error EmailRequired = new("Email.Required", "Email is required.");
    public static readonly Error InvalidEmailFormat = new("Email.InvalidFormat", "Email format is invalid.");
}