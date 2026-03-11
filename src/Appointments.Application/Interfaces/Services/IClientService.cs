using Appointments.Application.Dtos.Clients;

namespace Appointments.Application.Interfaces.Services;

public interface IClientService
{
    Task<IEnumerable<ClientResponse>> GetAllAsync();
    Task<ClientResponse?> GetByIdAsync(Guid id);
    Task<ClientResponse> CreateAsync(CreateClientRequest request);
    Task<ClientResponse?> UpdateContactInformationAsync(Guid id, UpdateContactInformationClientRequest request);
    Task<ClientResponse?> DeleteAsync(Guid id);
}