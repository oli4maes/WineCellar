using Microsoft.Extensions.DependencyInjection;

namespace WineCellar.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Mediator
        services.AddMediator();

        // AutoMapper
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}
