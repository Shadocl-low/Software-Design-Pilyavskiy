using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Laptop
{
    public class IPhoneLaptop : ILaptop
    {
        public string Brand { get; set; } = "IPhone";
        public string Model { get; set; } = "MacBook Pro";
        public string Processor { get; set; } = "M2";
        public int RamSize { get; set; } = 16;
        public double Price { get; set; } = 1299.99;

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