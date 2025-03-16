public interface ISubscription
{
    decimal MonthlyFee { get; set; }
    int MinimumPeriod { get; }
    List<string> Channels { get; }
    List<string> AdditionalFeatures { get; set; }
} 