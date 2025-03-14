using System;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public enum TransactionType
    {
        Inbound,
        Outbound
    }

    public class Transaction
    {
        public string TransactionId { get; }
        public DateTime Timestamp { get; }
        public TransactionType Type { get; }
        public string ProductSKU { get; }
        public int Quantity { get; }
        public IMoney UnitPrice { get; }

        public Transaction(TransactionType type, string productSKU, int quantity, IMoney unitPrice)
        {
            TransactionId = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            Timestamp = DateTime.Now;
            Type = type;
            ProductSKU = productSKU;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
} 