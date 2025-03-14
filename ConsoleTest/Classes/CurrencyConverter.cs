using System;

namespace ConsoleTest.Classes
{
    public static class CurrencyConverter
    {
        // Exchange rates relative to UAH (Ukrainian Hryvnia)
        private const decimal USD_TO_UAH = 41.50m;
        private const decimal EUR_TO_UAH = 42.20m;
        private const decimal UAH_TO_UAH = 1.00m;

        public static UAH ConvertToUAH(Money money)
        {
            decimal amountInUAH;
            decimal totalAmount = money.WholePart + (money.FractionalPart / 100m);

            switch (money.CurrencySymbol)
            {
                case "USD":
                    amountInUAH = totalAmount * USD_TO_UAH;
                    break;
                case "EUR":
                    amountInUAH = totalAmount * EUR_TO_UAH;
                    break;
                case "UAH":
                    amountInUAH = totalAmount * UAH_TO_UAH;
                    break;
                default:
                    throw new ArgumentException($"Unsupported currency: {money.CurrencySymbol}");
            }

            long wholePart = (long)Math.Floor(amountInUAH);
            int fractionalPart = (int)((amountInUAH - Math.Floor(amountInUAH)) * 100);

            return new UAH(wholePart, fractionalPart);
        }
    }
} 