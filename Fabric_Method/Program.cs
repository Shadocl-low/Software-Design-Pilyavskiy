
Console.WriteLine("Video Provider Subscription System Demo\n");

SubscriptionCreator[] creators = 
{
    new WebSite(),
    new MobileApp(),
    new ManagerCall()
};

string[] subscriptionTypes = { "domestic", "educational", "premium" };

foreach (var creator in creators)
{
    Console.WriteLine($"\nTesting {creator.GetType().Name}:");
    Console.WriteLine("----------------------------------------");

    foreach (var type in subscriptionTypes)
    {
        Console.WriteLine($"\nCreating {type} subscription:");
        var subscription = creator.CreateSubscription(type);

        Console.WriteLine($"Monthly Fee: ${subscription.MonthlyFee}");
        Console.WriteLine($"Minimum Period: {subscription.MinimumPeriod} months");

        Console.WriteLine("Channels:");
        foreach (var channel in subscription.Channels)
        {
            Console.WriteLine($"- {channel}");
        }

        Console.WriteLine("Additional Features:");
        foreach (var feature in subscription.AdditionalFeatures)
        {
            Console.WriteLine($"- {feature}");
        }

        Console.WriteLine("----------------------------------------");
    }
}

