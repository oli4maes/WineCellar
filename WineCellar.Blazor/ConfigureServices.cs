namespace WineCellar.Blazor;

public static class ConfigureServices
{
    public static IServiceCollection AddBlazorServices(this IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();

        return services;
    }
}
