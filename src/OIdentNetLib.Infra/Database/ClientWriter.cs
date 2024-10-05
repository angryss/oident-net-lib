using OIdentNetLib.Infra.Database.Contracts;
using OIdentNetLib.Infra.Database.Entities;

namespace OIdentNetLib.Infra.Database;

public class ClientWriter(OAuthSrvDbContext dbContext) : IClientWriter
{
    public async Task<Client> CreateAsync(Client client)
    {
        await dbContext.Clients.AddAsync(client);
        await dbContext.SaveChangesAsync();
        return client;
    }

    public async Task DeleteAsync(Guid id)
    {
        var client = await dbContext.Clients.FindAsync(id);
        if (client is not null)
        {
            dbContext.Clients.Remove(client);
            await dbContext.SaveChangesAsync();
        }
    }

    public async Task<Client> UpdateAsync(Client client)
    {
        dbContext.Clients.Update(client);
        await dbContext.SaveChangesAsync();
        return client;
    }
}