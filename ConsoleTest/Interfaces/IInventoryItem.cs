using System;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Interfaces
{
    public interface IInventoryItem
    {
        IProduct Product { get; set; }
        int Quantity { get; set; }
        string UnitOfMeasure { get; set; }
        DateTime LastRestockDate { get; set; }
    }
} 