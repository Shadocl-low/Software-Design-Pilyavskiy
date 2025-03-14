using System;
using System.Diagnostics;
using ConsoleTest.Interfaces;

namespace ConsoleTest.Classes
{
    public abstract class Money : IMoney
    {
        protected long wholePart;
        protected int fractionalPart;
        protected string currencySymbol;

        protected Money(long wholePart, int fractionalPart, string currencySymbol)
        {
            this.wholePart = wholePart;
            this.fractionalPart = fractionalPart;
            this.currencySymbol = currencySymbol;
            NormalizeAmount();
        }

        public long WholePart
        {
            get => wholePart;
            set
            {
                wholePart = value;
                NormalizeAmount();
            }
        }

        public int FractionalPart
        {
            get => fractionalPart;
            set
            {
                fractionalPart = value;
                NormalizeAmount();
            }
        }

        public string CurrencySymbol => currencySymbol;

        protected virtual void NormalizeAmount()
        {
            if (fractionalPart >= 100)
            {
                wholePart += fractionalPart / 100;
                fractionalPart %= 100;
            }
            else if (fractionalPart < 0)
            {
                if (wholePart > 0)
                {
                    wholePart--;
                    fractionalPart += 100;
                }
            }
        }

        public override string ToString()
        {
            return $"{wholePart}.{fractionalPart:D2} {currencySymbol}";
        }

        public virtual void SetAmount(long whole, int fractional)
        {
            wholePart = whole;
            fractionalPart = fractional;
            NormalizeAmount();
        }
        public virtual void SetAmount(decimal price)
        {
            wholePart = (long)Math.Floor(price);
            fractionalPart = (int)Math.Round((price - Math.Floor(price)) * 100);
            NormalizeAmount();
        }

        public virtual void AddAmount(decimal price)
        {
            wholePart += (long)Math.Floor(price);
            fractionalPart += (int)Math.Round((price - Math.Floor(price)) * 100);
            NormalizeAmount();
        }

        public virtual decimal GetDecimalMoney()
        {
            return wholePart + (fractionalPart / 100m);
        }
    }
} 