namespace Appointments.Application.Dtos.Clients;

public record UpdateContactInformationClientRequest(
    string? Name,
    string? PhoneNumber
);