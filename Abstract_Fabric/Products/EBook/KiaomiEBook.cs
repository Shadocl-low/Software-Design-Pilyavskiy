using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.EBook
{
    public class KiaomiEBook : IEBook
    {
        public string Brand { get; set; } = "Kiaomi";
        public string Model { get; set; } = "MiReader";
        public double ScreenSize { get; set; } = 6.8;
        public int StorageSize { get; set; } = 32;
        public bool Backlight { get; set; } = true;
        public double Price { get; set; } = 199.99;

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