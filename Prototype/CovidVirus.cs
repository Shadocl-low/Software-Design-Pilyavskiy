public class CovidVirus : Virus
{
    public CovidVirus(double weight, int age, string name, string species) 
        : base(weight, age, name, species)
    {
    }

    private CovidVirus(CovidVirus source) : base(source)
    {
    }

    public override Virus Clone()
    {
        return new CovidVirus(this);
    }

    public override void PrintVirusFamily(string indent = "")
    {
        Console.WriteLine($"{indent}{this}");
        foreach (var child in children)
        {
            child.PrintVirusFamily(indent + "  ");
        }
    }
} 