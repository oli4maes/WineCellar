using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WineCellar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddTransient<IGrapeRepository, GrapeRepository>();
        services.AddTransient<IUserWineRepository, UserWineRepository>();
        services.AddTransient<IWineRepository, WineRepository>();
        services.AddTransient<IWineryRepository, WineryRepository>();

        return services;
    }
}