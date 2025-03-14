using System;
using ConsoleTest.Classes;

namespace ConsoleTest.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        IMoney Price { get; set; }
        ProductCategory Category { get; set; }
        string SKU { get; }
    }
} 