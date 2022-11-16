using MudBlazor.Services;

namespace WineCellar.Blazor;

public static class ConfigureServices
{
    public static IServiceCollection AddBlazorServices(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();

        services.AddMudServices();

        return services;
    }
}
