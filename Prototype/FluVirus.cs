public class FluVirus : Virus
{
    private string strain;

    public FluVirus(double weight, int age, string name, string species, string strain) 
        : base(weight, age, name, species)
    {
        this.strain = strain;
    }

    private FluVirus(FluVirus source) : base(source)
    {
        this.strain = source.strain;
    }

    public override Virus Clone()
    {
        return new FluVirus(this);
    }

    public override void PrintVirusFamily(string indent = "")
    {
        Console.WriteLine($"{indent}{this}");
        foreach (var child in children)
        {
            child.PrintVirusFamily(indent + "  ");
        }
    }

    public override string ToString()
    {
        return $"Virus '{name}' (Species: {species}, Age: {age}, Weight: {weight:F2}, Children: {children.Count}, Strain: {strain})";
    }
} 