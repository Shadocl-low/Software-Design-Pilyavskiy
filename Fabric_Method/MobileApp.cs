using System;
using System.Net;
using System.Runtime.CompilerServices;

public class MobileApp : SubscriptionCreator
{
    private readonly List<string> _features = ["Download TV shows on phone"];
    public override ISubscription CreateSubscription(string type)
    {
        Console.WriteLine("Creating subscription through Mobile App...");
        Console.WriteLine("Applying mobile app special offer...");
        
        return type.ToLower() switch
        {
            "domestic" => AddNewAdditionalFeature(new DomesticSubscription()),
            "educational" => AddNewAdditionalFeature(new EducationalSubscription()),
            "premium" => AddNewAdditionalFeature(new PremiumSubscription()),
            _ => throw new ArgumentException("Invalid subscription type")
        };
    }
    private ISubscription AddNewAdditionalFeature(ISubscription subscription)
    {
        subscription.AdditionalFeatures.AddRange(_features);
        return subscription;
    }
} 