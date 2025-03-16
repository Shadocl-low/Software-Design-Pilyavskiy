using System.Collections.Generic;

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee { get; set; } = 199.99m;
    public int MinimumPeriod { get; } = 1;
    public List<string> Channels { get; } = new List<string>
    {
        "Local News",
        "Basic Entertainment",
        "Local Sports",
        "Family Channels"
    };
    public List<string> AdditionalFeatures { get; set; } = new List<string>
    {
        "SD Quality",
        "1 Device Stream"
    };
} 