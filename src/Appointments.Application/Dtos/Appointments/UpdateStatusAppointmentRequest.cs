using Appointments.Domain.Enums;

namespace Appointments.Application.Dtos.Appointments;

public record UpdateStatusAppointmentRequest(
    AppointmentStatus Status
);