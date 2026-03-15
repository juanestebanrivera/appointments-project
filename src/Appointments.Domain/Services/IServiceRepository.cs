using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Services;

public interface IServiceRepository : IRepository<Service>
{
    Task<IEnumerable<Service>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Service?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Service entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(Service entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(Service entity, CancellationToken cancellationToken = default);
}
