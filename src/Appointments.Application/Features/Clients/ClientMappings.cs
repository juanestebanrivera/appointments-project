using Appointments.Domain.Clients;

namespace Appointments.Application.Features.Clients;

public static class ClientMappings
{
    extension(Client client)
    {
        public ClientResponse ToClientResponse()
        {
            return new ClientResponse(
                client.Id,
                client.FirstName.Value,
                client.LastName.Value,
                client.Phone.Prefix,
                client.Phone.Number,
                client.Email?.Value,
                client.IsActive
            );
        }
    }
}