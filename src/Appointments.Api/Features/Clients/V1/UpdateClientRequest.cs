namespace Appointments.Api.Features.Clients.V1;

public record UpdateClientRequest(
    string FirstName,
    string LastName,
    string? Email,
    string PhonePrefix,
    string PhoneNumber,
    bool IsActive
);