using System;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public class InventoryItem : IInventoryItem
    {
        public IProduct Product { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime LastRestockDate { get; set; }

        public InventoryItem(IProduct product, int quantity, string unitOfMeasure)
        {
            Product = product;
            Quantity = quantity;
            UnitOfMeasure = unitOfMeasure;
            LastRestockDate = DateTime.Now;
        }
    }
} 