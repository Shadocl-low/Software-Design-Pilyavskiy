using System.Collections.Generic;

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee { get; set; } = 299.99m;
    public int MinimumPeriod { get; } = 3;
    public List<string> Channels { get; } = new List<string>
    {
        "Discovery Channel",
        "National Geographic",
        "History Channel",
        "Science Channel",
        "Educational Programs"
    };
    public List<string> AdditionalFeatures { get; set; } = new List<string>
    {
        "HD Quality",
        "2 Device Streams",
        "Offline Downloads",
        "Interactive Learning Materials"
    };
} 