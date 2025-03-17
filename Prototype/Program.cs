var grandparentVirus = new CovidVirus(1.5, 10, "Alpha", "COVID-19");

var parentVirus1 = new CovidVirus(1.2, 5, "Beta-1", "COVID-19");
var parentVirus2 = new CovidVirus(1.3, 5, "Beta-2", "COVID-19");

var childVirus1 = new CovidVirus(0.8, 2, "Gamma-1", "COVID-19");
var childVirus2 = new FluVirus(0.9, 2, "Gamma-2", "FLU", "H1N1");
var childVirus3 = new CovidVirus(1.0, 2, "Gamma-3", "COVID-19");

grandparentVirus.AddChild(parentVirus1);
grandparentVirus.AddChild(parentVirus2);

parentVirus1.AddChild(childVirus1);
parentVirus1.AddChild(childVirus2);
parentVirus2.AddChild(childVirus3);

Console.WriteLine("Original virus family:");
grandparentVirus.PrintVirusFamily();

var clonedFamily = grandparentVirus.Clone();

Console.WriteLine("\nCloned virus family:");
clonedFamily.PrintVirusFamily();

grandparentVirus.SetName("Modified-Alpha");
childVirus1.SetName("Modified-Gamma-1");

Console.WriteLine("\nOriginal virus family after modification:");
grandparentVirus.PrintVirusFamily();

Console.WriteLine("\nCloned virus family remains unchanged:");
clonedFamily.PrintVirusFamily();

