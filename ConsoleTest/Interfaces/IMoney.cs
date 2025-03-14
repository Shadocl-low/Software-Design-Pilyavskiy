using System;

namespace ConsoleTest.Interfaces
{
    public interface IMoney
    {
        long WholePart { get; set; }
        int FractionalPart { get; set; }
        string CurrencySymbol { get; }
        void SetAmount(long whole, int fractional);
        void SetAmount(decimal price);
        void AddAmount(decimal price);
        decimal GetDecimalMoney();
    }
} 