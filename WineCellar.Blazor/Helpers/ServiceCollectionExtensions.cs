namespace WineCellar.Blazor.Helpers;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMudBlazorThemeHelper<TThemeHelper>(this IServiceCollection services)
        where TThemeHelper : IMudBlazorThemeHelper
    {
        return services.AddSingleton(typeof(IMudBlazorThemeHelper), typeof(TThemeHelper));
    }
}