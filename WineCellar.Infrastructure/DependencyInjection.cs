using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WineCellar.Application.Interfaces;

namespace WineCellar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        services.AddScoped<IUnitOfWork, UnitOfWork>();        

        return services;
    }
}
