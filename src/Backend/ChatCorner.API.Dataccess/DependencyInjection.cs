using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using Microsoft.Extensions.DependencyInjection;

namespace ChatCorner.API.Dataccess;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<IChatMessageRepository, ChatMessageRepository>();
        return services;
    }
}