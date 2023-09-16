namespace Serilog.Enhancers;

public class SerilogEnhancedSettings
{
    public string CorrelationKey { get; set; } = "x-correlation-id";
    public string DefaultCorrelationId { get; set; } = "ac366e89-aac4-4250-a2c1-d1f79c1a8d7f";
    public string CorrelationIdPropertyName { get; set; } = "CorrelationId";
}