using System.Text.RegularExpressions;
using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Clients;

public partial record Email
{
    public string Value { get; }

    private Email(string value) 
    {
        Value = value;
    }

    public static Result<Email> Create(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return Result<Email>.Failure(EmailErrors.EmailRequired);

        if (!EmailFormatRegex().IsMatch(email))
            return Result<Email>.Failure(EmailErrors.InvalidEmailFormat);

        return Result<Email>.Success(new Email(email.ToLowerInvariant()));
    }

    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex EmailFormatRegex();
}