using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Clients;

public static class PersonNameErrors
{
    public static Error IsRequired(string fieldName) => new($"{fieldName}.Required", $"{fieldName} is required.");
    public static Error CannotContainNumbers(string fieldName) => new($"{fieldName}.CannotContainNumbers", $"{fieldName} cannot contain numbers.");
    public static Error MustBeAtLeastTwoCharacters(string fieldName) => new($"{fieldName}.MustBeAtLeastTwoCharacters", $"{fieldName} must be at least 2 characters long.");
}