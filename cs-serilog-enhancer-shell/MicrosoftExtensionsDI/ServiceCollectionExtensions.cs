namespace Serilog.Enhancers;

using Enrichers;

using Interfaces;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSerilogEnhancedLogger(this IServiceCollection services)
    {
        services.AddSingleton(typeof(IEnhancedLogger<>), typeof(EnhancedLogger<>));
        services.AddSingleton<HttpContextEnricher>();
        return services;
    }

    public static void AttachHttpEnricher(this LoggerConfiguration loggerConfiguration, IServiceProvider serviceProvider)
    {
        var enricher = serviceProvider.GetRequiredService<HttpContextEnricher>();
        loggerConfiguration
            .Enrich.With(enricher);
    }
}