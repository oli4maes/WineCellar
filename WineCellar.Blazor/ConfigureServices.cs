﻿using Auth0.AspNetCore.Authentication;
using MudBlazor.Services;
using WineCellar.Blazor.Helpers;

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
        services.AddServerSideBlazor()
            .AddHubOptions(options =>
            {
                options.ClientTimeoutInterval = TimeSpan.FromSeconds(60);
                options.HandshakeTimeout = TimeSpan.FromSeconds(30);
            });

        // MudBlazor
        services.AddMudServices(config =>
            {
                // Snackbar
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Text;
            }
        );

        // MudBlazor Theme
        services.AddMudBlazorThemeHelper<MudBlazorThemeHelper>();

        return services;
    }
}