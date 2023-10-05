using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WineCellar.Domain.Persistence;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddTransient<IGrapeRepository, GrapeRepository>();
        services.AddTransient<IBottleRepository, BottleRepository>();
        services.AddTransient<IWineRepository, WineRepository>();
        services.AddTransient<IWineryRepository, WineryRepository>();

        services.AddTransient<IQueryFacade, QueryFacade>();

        return services;
    }
}