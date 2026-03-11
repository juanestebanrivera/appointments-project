namespace Appointments.Application.Dtos.Appointments;

public record CreateAppointmentRequest(
    Guid ClientId,
    Guid ServiceId,
    DateTimeOffset ScheduledTime,
    TimeSpan Duration
);