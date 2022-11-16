using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WineCellar.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
