using System;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public enum ProductCategory
    {
        Food,
        Electronics,
        Clothing,
        Furniture,
        Other
    }

    public class Product : IProduct, IApplyDiscount
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IMoney Price { get; set; }
        public ProductCategory Category { get; set; }
        public string SKU { get; private set; }

        public Product(string name, string description, IMoney price, ProductCategory category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            SKU = GenerateSKU();
        }

        public void ApplyDiscount(decimal discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Discount percentage must be between 0 and 100");
            }

            decimal discountedAmount = Price.GetDecimalMoney() * (1 - discountPercentage / 100);

            Price.SetAmount(discountedAmount);
        }

        private string GenerateSKU()
        {
            return $"{Category.ToString().Substring(0, 3)}-{DateTime.Now.Ticks % 100000:D5}";
        }

        public override string ToString()
        {
            return $"{Name} ({SKU}) - {Price}";
        }
    }
} 