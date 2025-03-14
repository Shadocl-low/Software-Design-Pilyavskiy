using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public class Reporting
    {
        private readonly List<ITransaction> transactions;
        private readonly IWarehouse warehouse;
        private const string DateFormat = "yyyy-MM-dd HH:mm:ss";
        private const string SeparatorLine = "================================================";
        private const string ItemSeparator = "------------------------------------------------";

        public Reporting(IWarehouse warehouse)
        {
            this.warehouse = warehouse;
            transactions = new List<ITransaction>();
        }

        public string RegisterInboundTransaction(IProduct product, int quantity)
        {
            var transaction = new Transaction(TransactionType.Inbound, product.SKU, quantity, product.Price);
            transactions.Add(transaction);
            warehouse.AddProduct(product, quantity, "pcs"); // Default unit of measure
            return transaction.TransactionId;
        }

        public string RegisterOutboundTransaction(IProduct product, int quantity)
        {
            if (warehouse.RemoveProduct(product.SKU, quantity))
            {
                var transaction = new Transaction(TransactionType.Outbound, product.SKU, quantity, product.Price);
                transactions.Add(transaction);
                return transaction.TransactionId;
            }
            throw new InvalidOperationException("Insufficient stock for outbound transaction");
        }

        public IEnumerable<ITransaction> GetTransactionHistory()
        {
            return transactions.OrderByDescending(t => t.Timestamp).ToList();
        }

        public string GenerateInventoryReport(IWarehouse warehouse)
        {
            var inventory = warehouse.GetAllInventory();
            var report = $"Inventory Report - {DateTime.Now.ToString(DateFormat)}\n";
            report += $"{SeparatorLine}\n";
            
            foreach (var item in inventory.OrderBy(i => i.Product.Category).ThenBy(i => i.Product.Name))
            {
                report += FormatInventoryItem(item);
                report += $"{ItemSeparator}\n";
            }

            return report;
        }

        private string FormatInventoryItem(IInventoryItem item)
        {
            return $"SKU: {item.Product.SKU}\n" +
                   $"Product: {item.Product.Name}\n" +
                   $"Category: {item.Product.Category}\n" +
                   $"Quantity: {item.Quantity} {item.UnitOfMeasure}\n" +
                   $"Unit Price: {item.Product.Price}\n" +
                   $"Last Restock: {item.LastRestockDate.ToString(DateFormat)}\n";
        }
    }
} 