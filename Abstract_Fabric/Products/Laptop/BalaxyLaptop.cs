using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Laptop
{
    public class BalaxyLaptop : ILaptop
    {
        public string Brand { get; set; } = "Balaxy";
        public string Model { get; set; } = "Galaxy Book Pro";
        public string Processor { get; set; } = "Intel i7";
        public int RamSize { get; set; } = 16;
        public double Price { get; set; } = 1099.99;

        public void DisplayInfo()
        {
            Console.WriteLine($"Laptop: {Brand} {Model}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RamSize}GB");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine("------------------------");
        }
    }
} 