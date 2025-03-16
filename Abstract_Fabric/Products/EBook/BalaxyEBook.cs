using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.EBook
{
    public class BalaxyEBook : IEBook
    {
        public string Brand { get; set; } = "Balaxy";
        public string Model { get; set; } = "Galaxy Tab";
        public double ScreenSize { get; set; } = 10.9;
        public int StorageSize { get; set; } = 128;
        public bool Backlight { get; set; } = true;
        public double Price { get; set; } = 399.99;

        public void DisplayInfo()
        {
            Console.WriteLine($"E-Book: {Brand} {Model}");
            Console.WriteLine($"Screen Size: {ScreenSize}\"");
            Console.WriteLine($"Storage: {StorageSize}GB");
            Console.WriteLine($"Backlight: {(Backlight ? "Yes" : "No")}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine("------------------------");
        }
    }
} 