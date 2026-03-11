namespace Appointments.Application.Dtos.Services;

public record ServiceResponse(
    string Name,
    decimal Price,
    TimeSpan EstimatedDuration,
    bool IsActive
);