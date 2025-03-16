using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Smartphone
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Brand { get; set; } = "Balaxy";
        public string Model { get; set; } = "Galaxy S23";
        public string Processor { get; set; } = "Snapdragon 8 Gen 2";
        public int RamSize { get; set; } = 8;
        public double ScreenSize { get; set; } = 6.8;
        public int BatteryCapacity { get; set; } = 3900;
        public double Price { get; set; } = 999.99;

        public void DisplayInfo()
        {
            Console.WriteLine($"Smartphone: {Brand} {Model}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RamSize}GB");
            Console.WriteLine($"Screen Size: {ScreenSize}\"");
            Console.WriteLine($"Battery: {BatteryCapacity}mAh");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine("------------------------");
        }
    }
} 