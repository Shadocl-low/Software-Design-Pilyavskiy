using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.EBook
{
    public class IPhoneEBook : IEBook
    {
        public string Brand { get; set; } = "IPhone";
        public string Model { get; set; } = "iBook";
        public double ScreenSize { get; set; } = 7.9;
        public int StorageSize { get; set; } = 64;
        public bool Backlight { get; set; } = true;
        public double Price { get; set; } = 299.99;

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