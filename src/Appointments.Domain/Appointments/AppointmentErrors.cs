using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Appointments;

public static class AppointmentErrors
{
    public static readonly Error ClientIsRequired = new ("Appointment.ClientIsRequired", "Client is required");
    
    public static readonly Error ServiceIsRequired = new ("Appointment.ServiceIsRequired", "Service is required");
    public static readonly Error PriceAtBookingMustBeGreaterThanZero = new ("Appointment.PriceAtBookingMustBeGreaterThanZero", "Price at booking must be greater than zero.");

    public static readonly Error TimeCannotBeInThePast = new ("Appointment.TimeCannotBeInThePast", "Appointment time cannot be in the past.");
    public static readonly Error TimeMustBeMoreThanFiveMinutes = new ("Appointment.TimeMustBeMoreThanFiveMinutes", "Appointment time must be more than five minutes.");
    public static readonly Error TimeMustBeLessThanOneDay = new ("Appointment.TimeMustBeLessThanOneDay", "Appointment time must be less than one day.");
    public static readonly Error EndTimeMustBeAfterStartTime = new ("Appointment.EndTimeMustBeAfterStartTime", "End time must be after start time.");

    public static readonly Error InvalidStatusTransition = new ("Appointment.InvalidStatusTransition", "Invalid status transition.");
}