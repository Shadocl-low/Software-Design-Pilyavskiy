using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Smartphone
{
    public class IPhoneSmartphone : ISmartphone
    {
        public string Brand { get; set; } = "IPhone";
        public string Model { get; set; } = "iPhone 15";
        public string Processor { get; set; } = "A17";
        public int RamSize { get; set; } = 6;
        public double ScreenSize { get; set; } = 6.1;
        public int BatteryCapacity { get; set; } = 3200;
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