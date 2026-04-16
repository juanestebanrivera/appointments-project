namespace Appointments.Api.Features.Appointments.V1;

public record RescheduleAppointmentRequest(
    DateTimeOffset NewStartTime
);