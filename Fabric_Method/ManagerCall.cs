using System;

public class ManagerCall : SubscriptionCreator
{
    public override ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription through Manager Call...");
        Console.WriteLine("Applying personal manager assistance and special conditions...");
        
        return type.ToLower() switch
        {
            "domestic" => new DomesticSubscription(),
            "educational" => new EducationalSubscription(),
            "premium" => new PremiumSubscription(),
            _ => throw new ArgumentException("Invalid subscription type")
        };
    }
} 