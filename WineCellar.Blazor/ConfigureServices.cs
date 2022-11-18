using Auth0.AspNetCore.Authentication;
using MudBlazor.Services;

namespace WineCellar.Blazor;

public static class ConfigureServices
{
    public static IServiceCollection AddBlazorServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Auth0
        services.AddAuth0WebAppAuthentication(options =>
        {
            options.Domain = configuration["Auth0:Domain"];
            options.ClientId = configuration["Auth0:ClientId"];
        });

        services.AddRazorPages();
        services.AddServerSideBlazor();

        services.AddMudServices();

        return services;
    }
}
