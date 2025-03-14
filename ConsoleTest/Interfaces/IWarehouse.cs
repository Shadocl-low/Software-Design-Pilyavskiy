using System.Collections.Generic;
using ConsoleTest.Classes;

namespace ConsoleTest.Interfaces
{
    public interface IWarehouse
    {
        void AddProduct(IProduct product, int quantity, string unitOfMeasure);
        bool RemoveProduct(string sku, int quantity);
        IEnumerable<IInventoryItem> GetAllInventory();
    }
} 