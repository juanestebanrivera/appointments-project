using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Appointments;

public interface IAppointmentRepository : IRepository<Appointment>
{
    Task<IEnumerable<Appointment>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Appointment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Appointment entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(Appointment entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(Appointment entity, CancellationToken cancellationToken = default);
}
