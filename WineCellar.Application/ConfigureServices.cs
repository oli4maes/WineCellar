﻿using Microsoft.Extensions.DependencyInjection;
using WineCellar.Application.Behaviours;

namespace WineCellar.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Mediator
        services.AddMediator();

        // Pipeline Behaviours
        services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehaviour<,>));

        return services;
    }
}