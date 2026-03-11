using Appointments.Domain.Enums;

namespace Appointments.Application.Dtos.Appointments;

public record AppointmentResponse(
    Guid Id,
    Guid ClientId,
    Guid ServiceId,
    DateTimeOffset ScheduledTime,
    TimeSpan Duration,
    AppointmentStatus Status
);