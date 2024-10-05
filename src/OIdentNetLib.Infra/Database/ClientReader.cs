using Microsoft.EntityFrameworkCore;
using OIdentNetLib.Infra.Database.Contracts;
using OIdentNetLib.Infra.Database.Entities;

namespace OIdentNetLib.Infra.Database;

public class ClientReader(OAuthSrvDbContext dbContext) : IClientReader
{
    public async Task<Client?> GetByIdAsync(Guid id)
    {
        var results = from c in dbContext.Clients
            where c.ClientId == id
            select c;
        return await results.FirstOrDefaultAsync();
    }

    public async Task<Client?> GetByNameAsync(string name)
    {
        var results = from c in dbContext.Clients
            where c.Name == name
            select c;
        return await results.FirstOrDefaultAsync();
    }

    public async Task<IList<Client>> GetByTenantAsync(Guid tenantId)
    {
        var results = from c in dbContext.Clients
            where c.TenantId == tenantId
            orderby c.Name
            select c;
        return await results.ToListAsync();
    }
}