using System.Collections.Generic;
using System.Linq;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public class Warehouse : IWarehouse
    {
        private readonly Dictionary<string, IInventoryItem> inventory;

        public Warehouse()
        {
            inventory = new Dictionary<string, IInventoryItem>();
        }

        public void AddProduct(IProduct product, int quantity, string unitOfMeasure)
        {
            if (inventory.ContainsKey(product.SKU))
            {
                var item = inventory[product.SKU];
                item.Quantity += quantity;
                item.LastRestockDate = System.DateTime.Now;
            }
            else
            {
                inventory[product.SKU] = new InventoryItem(product, quantity, unitOfMeasure);
            }
        }

        public bool RemoveProduct(string sku, int quantity)
        {
            if (!inventory.ContainsKey(sku))
                return false;

            var item = inventory[sku];
            if (item.Quantity < quantity)
                return false;

            item.Quantity -= quantity;
            
            if (item.Quantity == 0)
                inventory.Remove(sku);

            return true;
        }

        public IInventoryItem GetInventoryItem(string sku)
        {
            return inventory.TryGetValue(sku, out var item) ? item : null;
        }

        public IEnumerable<IInventoryItem> GetAllInventory()
        {
            return inventory.Values.ToList();
        }

        public void UpdateStock(string sku, int quantity)
        {
            if (inventory.ContainsKey(sku))
            {
                inventory[sku].Quantity = quantity;
                inventory[sku].LastRestockDate = System.DateTime.Now;
            }
        }
    }
} 