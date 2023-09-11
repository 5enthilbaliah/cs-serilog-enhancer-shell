namespace Serilog.Enhancers;

using Interfaces;

public class EnhancedLogger<TContext> : IEnhancedLogger<TContext>
{
    private readonly ILogger _logger;

    public EnhancedLogger(ILogger logger)
    {
        if (logger is null)
            throw new ArgumentNullException(nameof(logger));

        _logger = logger.ForContext<TContext>();
    }


    public void LogVerbose(string messageTemplate)
    {
        _logger.Verbose(messageTemplate);
    }

    public void LogVerbose<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Verbose(messageTemplate, propertyValue);
    }

    public void LogVerbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Verbose(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogVerbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogVerbose(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Verbose(messageTemplate, propertyValues);
    }

    public void LogVerbose(Exception? exception, string messageTemplate)
    {
        _logger.Verbose(exception, messageTemplate);
    }

    public void LogVerbose<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Verbose(exception, messageTemplate, propertyValue);
    }

    public void LogVerbose<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Verbose(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogVerbose<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Verbose(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogVerbose(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Verbose(exception, messageTemplate, propertyValues);
    }

    public void LogDebug(string messageTemplate)
    {
        _logger.Debug(messageTemplate);
    }

    public void LogDebug<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Debug(messageTemplate, propertyValue);
    }

    public void LogDebug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Debug(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogDebug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogDebug(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Debug(messageTemplate, propertyValues);
    }

    public void LogDebug(Exception? exception, string messageTemplate)
    {
        _logger.Debug(exception, messageTemplate);
    }

    public void LogDebug<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Debug(exception, messageTemplate, propertyValue);
    }

    public void LogDebug<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Debug(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogDebug<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Debug(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogDebug(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Debug(exception, messageTemplate, propertyValues);
    }

    public void LogInformation(string messageTemplate)
    {
        _logger.Information(messageTemplate);
    }

    public void LogInformation<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Information(messageTemplate, propertyValue);
    }

    public void LogInformation<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Information(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogInformation<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogInformation(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Information(messageTemplate, propertyValues);
    }

    public void LogInformation(Exception? exception, string messageTemplate)
    {
        _logger.Information(exception, messageTemplate);
    }

    public void LogInformation<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Information(exception, messageTemplate, propertyValue);
    }

    public void LogInformation<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Information(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogInformation<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Information(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogInformation(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Information(exception, messageTemplate, propertyValues);
    }

    public void LogWarning(string messageTemplate)
    {
        _logger.Warning(messageTemplate);
    }

    public void LogWarning<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Warning(messageTemplate, propertyValue);
    }

    public void LogWarning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Warning(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogWarning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogWarning(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Warning(messageTemplate, propertyValues);
    }

    public void LogWarning(Exception? exception, string messageTemplate)
    {
        _logger.Warning(exception, messageTemplate);
    }

    public void LogWarning<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Warning(exception, messageTemplate, propertyValue);
    }

    public void LogWarning<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Warning(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogWarning<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Warning(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogWarning(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Warning(exception, messageTemplate, propertyValues);
    }

    public void LogError(string messageTemplate)
    {
        _logger.Error(messageTemplate);
    }

    public void LogError<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Error(messageTemplate, propertyValue);
    }

    public void LogError<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Error(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogError<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogError(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Error(messageTemplate, propertyValues);
    }

    public void LogError(Exception? exception, string messageTemplate)
    {
        _logger.Error(exception, messageTemplate);
    }

    public void LogError<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Error(exception, messageTemplate, propertyValue);
    }

    public void LogError<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Error(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogError<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Error(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogError(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Error(exception, messageTemplate, propertyValues);
    }

    public void LogFatal(string messageTemplate)
    {
        _logger.Fatal(messageTemplate);
    }

    public void LogFatal<T1>(string messageTemplate, T1 propertyValue)
    {
        _logger.Fatal(messageTemplate, propertyValue);
    }

    public void LogFatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Fatal(messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogFatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
    {
        _logger.Fatal(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogFatal(string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Fatal(messageTemplate, propertyValues);
    }

    public void LogFatal(Exception? exception, string messageTemplate)
    {
        _logger.Fatal(exception, messageTemplate);
    }

    public void LogFatal<T1>(Exception? exception, string messageTemplate, T1 propertyValue)
    {
        _logger.Fatal(exception, messageTemplate, propertyValue);
    }

    public void LogFatal<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
    {
        _logger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1);
    }

    public void LogFatal<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2)
    {
        _logger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
    }

    public void LogFatal(Exception? exception, string messageTemplate, params object?[]? propertyValues)
    {
        _logger.Fatal(exception, messageTemplate, propertyValues);
    }
}