using System;
using System.Collections.Generic;

public abstract class Virus
{
    protected double weight;
    protected int age;
    protected string name;
    protected string species;
    protected List<Virus> children;

    public void SetName(string name)
    {
        this.name = name;
    }

    protected Virus(double weight, int age, string name, string species)
    {
        this.weight = weight;
        this.age = age;
        this.name = name;
        this.species = species;
        this.children = new List<Virus>();
    }

    protected Virus(Virus source)
    {
        this.weight = source.weight;
        this.age = source.age;
        this.name = source.name;
        this.species = source.species;
        this.children = new List<Virus>();
        
        foreach (var child in source.children)
        {
            this.children.Add(child.Clone());
        }
    }

    public void AddChild(Virus child)
    {
        children.Add(child);
    }

    public abstract Virus Clone();

    public abstract void PrintVirusFamily(string indent = "");

    public override string ToString()
    {
        return $"Virus '{name}' (Species: {species}, Age: {age}, Weight: {weight:F2}, Children: {children.Count})";
    }
} 