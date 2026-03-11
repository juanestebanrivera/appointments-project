namespace Appointments.Application.Dtos.Appointments;

public record RescheduleAppointmentRequest(
    DateTimeOffset ScheduledTime,
    TimeSpan Duration
);