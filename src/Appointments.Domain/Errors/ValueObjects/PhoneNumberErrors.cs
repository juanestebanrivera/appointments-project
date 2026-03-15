using Appointments.Domain.Shared;

namespace Appointments.Domain.Errors.ValueObjects;

public static class PhoneNumberErrors
{
    public static readonly Error PhonePrefixRequired = new("PhoneNumber.PrefixRequired", "Phone number prefix is required.");
    public static readonly Error InvalidPhonePrefix = new("PhoneNumber.InvalidPrefix", "Phone number prefix is invalid.");

    public static readonly Error PhoneNumberRequired = new("PhoneNumber.Required", "Phone number is required.");
    public static readonly Error InvalidPhoneNumberFormat = new("PhoneNumber.InvalidFormat", "Phone number format is invalid.");
}