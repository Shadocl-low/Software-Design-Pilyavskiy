using System;
using ConsoleTest.Classes;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Interfaces
{
    public interface ITransaction
    {
        string TransactionId { get; }
        DateTime Timestamp { get; }
        TransactionType Type { get; }
        string ProductSKU { get; }
        int Quantity { get; }
        IMoney UnitPrice { get; }
    }
} 