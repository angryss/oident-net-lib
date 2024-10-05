using OIdentNetLib.Infra.Database.Entities;

namespace OIdentNetLib.Infra.Database.Contracts;

public interface IClientWriter
{
    Task<Client> CreateAsync(Client client);
    Task DeleteAsync(Guid id);
    Task<Client> UpdateAsync(Client client);
}