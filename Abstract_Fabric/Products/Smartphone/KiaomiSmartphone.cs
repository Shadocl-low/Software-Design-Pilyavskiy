using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Smartphone
{
    public class KiaomiSmartphone : ISmartphone
    {
        public string Brand { get; set; } = "Kiaomi";
        public string Model { get; set; } = "Mi 13";
        public string Processor { get; set; } = "Snapdragon 8 Gen 2";
        public int RamSize { get; set; } = 8;
        public double ScreenSize { get; set; } = 6.7;
        public int BatteryCapacity { get; set; } = 4500;
        public double Price { get; set; } = 799.99;

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