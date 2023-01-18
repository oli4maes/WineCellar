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
            options.Domain = configuration["Auth0:Domain"] ?? throw new InvalidOperationException();
            options.ClientId = configuration["Auth0:ClientId"] ?? throw new InvalidOperationException();
        });

        // Authorization policies
        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminRole", policy => policy.RequireRole("admin"));
        });

        services.AddRazorPages();
        services.AddServerSideBlazor();

        services.AddMudServices();

        return services;
    }
}
