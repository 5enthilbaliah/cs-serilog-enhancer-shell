namespace Serilog.Enhancers.Enrichers;

using Core;

using Events;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

public class HttpContextEnricher : ILogEventEnricher
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly SerilogEnhancedSettings _serilogEnhancerSettings;


    public HttpContextEnricher(IHttpContextAccessor httpContextAccessor,
        IOptions<SerilogEnhancedSettings> serilogEnhancerSettingOptions)
    {
        _httpContextAccessor = httpContextAccessor;
        _serilogEnhancerSettings = serilogEnhancerSettingOptions?.Value ?? new SerilogEnhancedSettings();
    }

    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        var correlationId = _serilogEnhancerSettings.DefaultCorrelationId;
        if (httpContext is not null)
        {
            correlationId = GetCorrelationId(httpContext);
        }

        var correlationIdProperty = new LogEventProperty(_serilogEnhancerSettings.CorrelationIdPropertyName,
            new ScalarValue(correlationId));

        logEvent.AddOrUpdateProperty(correlationIdProperty);
    }

    private string GetCorrelationId(HttpContext httpContext)
    {
        var header = _serilogEnhancerSettings.DefaultCorrelationId;

        if (httpContext.Request.Headers.TryGetValue(_serilogEnhancerSettings.CorrelationKey, out var values))
        {
            header = values.FirstOrDefault();
        }

        var correlationId = string.IsNullOrEmpty(header)
            ? Guid.NewGuid().ToString()
            : header;

        return correlationId;
    }
}