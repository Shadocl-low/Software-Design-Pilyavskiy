# Пилявський Олександр Іванович
# vt231_poi@student.ztu.edu.ua

# Warehouse Management System

This project demonstrates various programming principles through a warehouse management system implementation. Below are detailed explanations of how each principle is applied in the codebase.

## SOLID Principles

### 1. Single Responsibility Principle (SRP)
A class should have only one reason to change.
Each class has a single, well-defined responsibility:
1. [Money](ConsoleTest/Classes/Money.cs) class - handles only currency-related operations
2. [Product](ConsoleTest/Classes/Product.cs) class - manages product information
3. [Warehouse](ConsoleTest/Classes/Warehouse.cs) class - handles inventory management
4. [Reporting](ConsoleTest/Classes/Reporting.cs) class - manages reporting and transactions

### 2. Open/Closed Principle (OCP)
Software entities should be open for extension but closed for modification.
1. We can easily add new [currencies](ConsoleTest/Classes/UAH.cs) to currency system through abstract [Money](ConsoleTest/Classes/Money.cs#L1-L30) class without modifying existing code.
2. Product [categories](ConsoleTest/Classes/Product.cs#L6-L13) can be extended.

### 3. Liskov Substitution Principle (LSP)
Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.
1. Any [class that inheritance from Money](ConsoleTest/Classes/USD.cs) can be used wherever [Money](ConsoleTest/Classes/Money.cs) is expected.
2. Any [class that implements IProduct](ConsoleTest/Classes/Product.cs) can be used wherever [IProduct](ConsoleTest/Interfaces/IProduct.cs) is expected.

### 4. Interface Segregation Principle (ISP)
A class should not be forced to depend on interfaces they don't use and interfaces should be small and own single responsibility.
1. [IApplyDiscount](ConsoleTest/Interfaces/IApplyDiscount.cs) has no unnecessary methods that would force [Product](ConsoleTest/Classes/Product.cs) to implement. `Product` implements methods from an interface and all of them are necessary.
2. [IMoney](ConsoleTest/Interfaces/IMoney.cs) responsibility is only abstract [Money](ConsoleTest/Classes/Money.cs) class.

### 5. Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions.
1. [Product](ConsoleTest/Classes/Product.cs) depends on [Money](ConsoleTest/Classes/Money.cs), so `Money` was replaces into [IMoney](ConsoleTest/Classes/IMoney.cs). In that way `Product` depend on abstraction.
2. Same for [Reporting](ConsoleTest/Classes/Reporting.cs#L11), [Warehouse](ConsoleTest/Classes/Warehouse.cs#L7-L9), [InventoryItem](ConsoleTest/Classes/InventoryItem.cs#L6-L8). They depend on abstraction [IWarehouse](ConsoleTest/Interfaces/IWarehouse.cs), [IInventoryItem](ConsoleTest/Interfaces/IInventoryItem.cs), [IProduct](ConsoleTest/Interfaces/IProduct.cs).

## Other Programming Principles

### 1. DRY (Don't Repeat Yourself)
Avoid duplicating code in a system.
1. We can reuse [this method](ConsoleTest/Classes/Money.cs#L43-L58) in several places:
   + in the [constructor](ConsoleTest/Classes/Money.cs#L13-L19).
   + when setting [WholePart](ConsoleTest/Classes/Money.cs#L21-L29) and [FractionalPart](ConsoleTest/Classes/Money.cs#L31-L39).
   + in [SetAmount](ConsoleTest/Classes/Money.cs#L65-L70) and [AddAmount](ConsoleTest/Classes/Money.cs#L78-L83) methods.
2. [Base constructor](ConsoleTest/Classes/Money.cs#L13-L19) of abstract class is reused by all currency classes ([USD](ConsoleTest/Classes/USD.cs), [EUR](ConsoleTest/Classes/EUR.cs), [UAH](ConsoleTest/Classes/UAH.cs)) that prevents code duplication in derived classes.

### 2. KISS (Keep It Simple, Stupid)
Minimize complexity and make things easier to understand and use.
1. Simple [enumeration](ConsoleTest/Classes/Product.cs#L6-L13) of product categories that easy to understand and extend.
2. Clear [calculation](ConsoleTest/Classes/Product.cs#L32-L42) of discounted amount and straightforward update of price components.
3. Easy to understand [report generating](ConsoleTest/Classes/Reporting.cs#L46-L69) method.

## Testing and Usage
The system's functionality is demonstrated in the [Program.cs](ConsoleTest/Program.cs) file.

To run the demo:
1. Compile the project
2. Run [Program.cs](ConsoleTest/Program.cs) to see the system in action.