namespace Serilog.Enhancers;

using Interfaces;

using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSerilogEnhancedLogger(this IServiceCollection services)
    {
        services.AddSingleton(typeof(IEnhancedLogger<>), typeof(EnhancedLogger<>));
        return services;
    }
}