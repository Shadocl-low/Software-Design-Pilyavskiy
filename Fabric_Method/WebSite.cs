using System;

public class WebSite : SubscriptionCreator
{
    private readonly decimal _webDiscound = 0.1m;
    public override ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription through Website...");
        Console.WriteLine("Applying web discount...");
        
        return type.ToLower() switch
        {
            "domestic" => ApplyWebDiscount(new DomesticSubscription()),
            "educational" => ApplyWebDiscount(new EducationalSubscription()),
            "premium" => ApplyWebDiscount(new PremiumSubscription()),
            _ => throw new ArgumentException("Invalid subscription type")
        };
    }
    private ISubscription ApplyWebDiscount(ISubscription subscription)
    {
        subscription.MonthlyFee = Math.Round(subscription.MonthlyFee * (1 - _webDiscound), 2);
        return subscription;
    }
} 