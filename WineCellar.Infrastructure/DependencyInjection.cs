using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WineCellar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddScoped<IGrapeRepository, GrapeRepository>();        
        services.AddScoped<IUserWineRepository, UserWineRepository>();        
        services.AddScoped<IWineRepository, WineRepository>();        
        services.AddScoped<IWineryRepository, WineryRepository>();        

        return services;
    }
}
