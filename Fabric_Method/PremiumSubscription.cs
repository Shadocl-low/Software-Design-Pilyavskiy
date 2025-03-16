using System.Collections.Generic;

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee { get; set; } = 599.99m;
    public int MinimumPeriod { get; } = 6;
    public List<string> Channels { get; } = new List<string>
    {
        "Premium Movies",
        "Premium Sports",
        "Premium Entertainment",
        "All Local Channels",
        "International Channels",
        "Exclusive Content"
    };
    public List<string> AdditionalFeatures { get; set; } = new List<string>
    {
        "4K Ultra HD Quality",
        "4 Device Streams",
        "Offline Downloads",
        "Ad-Free Experience",
        "Priority Customer Support",
        "Early Access to New Content"
    };
} 