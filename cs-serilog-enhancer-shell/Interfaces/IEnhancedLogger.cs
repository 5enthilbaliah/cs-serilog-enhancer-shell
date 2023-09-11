namespace Serilog.Enhancers.Interfaces;

using Core;

using Events;

public interface IEnhancedLogger<TContext>
{
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogVerbose("Staring into space, wondering if we're alone.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose("Staring into space, wondering if we're alone.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose("Staring into space, wondering if we're alone.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose("Staring into space, wondering if we're alone.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose("Staring into space, wondering if we're alone.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogVerbose(ex, "Staring into space, wondering where this comet came from.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose(ex, "Staring into space, wondering where this comet came from.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose(ex, "Staring into space, wondering where this comet came from.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogVerbose(ex, "Staring into space, wondering where this comet came from.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Verbose"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug.Verbose(ex, "Staring into space, wondering where this comet came from.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogVerbose(Exception? exception, string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogDebug("Starting up at {StartedAt}.", DateTime.Now);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug("Starting up at {StartedAt}.", DateTime.Now);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug("Starting up at {StartedAt}.", DateTime.Now);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug("Starting up at {StartedAt}.", DateTime.Now);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug("Starting up at {StartedAt}.", DateTime.Now);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogDebug(ex, "Swallowing a mundane exception.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug(ex, "Swallowing a mundane exception.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug(ex, "Swallowing a mundane exception.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug(ex, "Swallowing a mundane exception.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Debug"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogDebug(ex, "Swallowing a mundane exception.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogDebug(Exception? exception, string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogInformation("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogInformation(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Information"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogInformation(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogInformation(Exception? exception, string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogWarning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning("Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogWarning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Warning"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogWarning(ex, "Skipped {SkipCount} records.", skippedRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogWarning(Exception? exception, string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogError("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError("Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogError(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Error"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogError(ex, "Failed {ErrorCount} records.", brokenRecords.Length);
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogError(Exception? exception, string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogFatal("Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal(string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal("Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T>(string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal("Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal("Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal("Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal(string messageTemplate, params object?[]? propertyValues);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <example><code>
    /// _logger.LogFatal(ex, "Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal(Exception? exception, string messageTemplate);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal(ex, "Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T>(Exception? exception, string messageTemplate, T propertyValue);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal(ex, "Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
    /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal(ex, "Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
        T2 propertyValue2);
    
    /// <summary>
    /// Write a log event with the <see cref="LogEventLevel.Fatal"/> level and associated exception.
    /// </summary>
    /// <param name="exception">Exception related to the event.</param>
    /// <param name="messageTemplate">Message template describing the event.</param>
    /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
    /// <example><code>
    /// _logger.LogFatal(ex, "Process terminating.");
    /// </code></example>
    [MessageTemplateFormatMethod("messageTemplate")]
    void LogFatal(Exception? exception, string messageTemplate, params object?[]? propertyValues);
}