using Microsoft.Extensions.DependencyInjection;
using OIdentNetLib.Infra.Database;
using OIdentNetLib.Infra.Database.Contracts;

namespace OIdentNetLib.Infra;

public static class ServiceRegistration
{
    public static void AddDatabaseServices(this IServiceCollection services)
    {
        services.AddScoped<IClientReader, ClientReader>();
        services.AddScoped<IClientWriter, ClientWriter>();
    }
}