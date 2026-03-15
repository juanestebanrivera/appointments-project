using Appointments.Domain.SharedKernel;

namespace Appointments.Domain.Clients;

public interface IClientRepository : IRepository<Client>
{
    Task<IEnumerable<Client>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Client entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(Client entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(Client entity, CancellationToken cancellationToken = default);
}