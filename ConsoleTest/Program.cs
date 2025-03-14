using System;
using System.Linq;
using ConsoleTest.Classes;

namespace WarehouseManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Warehouse Management System Demo ===\n");

            // 1. Створення екземплярів основних класів
            var warehouse = new Warehouse();
            var reporting = new Reporting(warehouse);

            // 2. Демонстрація роботи з грошима
            Console.WriteLine("=== Money Demo ===");
            var price1 = new USD(999, 99);
            var price2 = new EUR(899, 99);
            var price3 = new UAH(29999, 99);
            Console.WriteLine($"Price 1: {price1}");
            Console.WriteLine($"Price 2: {price2}");
            Console.WriteLine($"Price 3: {price3}\n");

            // 3. Створення та додавання продуктів на склад
            Console.WriteLine("=== Product Creation and Warehouse Management ===");
            var laptop = new Product("Laptop", "High-end gaming laptop", price1, ProductCategory.Electronics);
            var phone = new Product("Smartphone", "Latest model smartphone", price2, ProductCategory.Electronics);
            var chair = new Product("Office Chair", "Ergonomic office chair", price3, ProductCategory.Furniture);

            reporting.RegisterInboundTransaction(laptop, 5);
            reporting.RegisterInboundTransaction(phone, 10);
            reporting.RegisterInboundTransaction(chair, 15);

            // 4. Демонстрація знижки на продукт
            Console.WriteLine("=== Product Discount Demo ===");
            Console.WriteLine($"Original price: {laptop.Price}");
            laptop.ApplyDiscount(10); // 10% discount
            Console.WriteLine($"After 10% discount: {laptop.Price}\n");

            // 6. Демонстрація звітності
            Console.WriteLine("=== Reporting Demo ===");
            Console.WriteLine("Inventory Report:");
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));

            Console.WriteLine("Transaction History:");
            foreach (var transaction in reporting.GetTransactionHistory())
            {
                Console.WriteLine($"Transaction ID: {transaction.TransactionId}");
                Console.WriteLine($"Type: {transaction.Type}");
                Console.WriteLine($"Product SKU: {transaction.ProductSKU}");
                Console.WriteLine($"Quantity: {transaction.Quantity}");
                Console.WriteLine($"Unit Price: {transaction.UnitPrice}");
                Console.WriteLine($"Timestamp: {transaction.Timestamp}");
                Console.WriteLine("---");
            }

            // 7. Демонстрація видалення товарів зі складу
            Console.WriteLine("=== Warehouse Removal Demo ===");
            reporting.RegisterOutboundTransaction(laptop, 2);
            Console.WriteLine("Updated Inventory Report after removal:");
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 
