using OIdentNetLib.Infra.Database.Entities;

namespace OIdentNetLib.Infra.Database.Contracts;

public interface IAudienceReader
{
    Task<Client?> GetByIdAsync(Guid id);
    Task<Client?> GetByNameAsync(string name);
    Task<IList<Client>> GetByTenantAsync(Guid tenantId);
}