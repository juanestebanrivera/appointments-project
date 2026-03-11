namespace Appointments.Application.Dtos.Clients;

public record CreateClientRequest(
    string Name,
    string Email,
    DateTime DateOfBith,
    string? PhoneNumber
);