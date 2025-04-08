using Proxy.Proxies;
using Proxy;
using System.Runtime.CompilerServices;

string filePath = "example.txt";
File.WriteAllLines(filePath, ["Hello", "World!"]);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- Original Reader ---");
Console.ResetColor();
SmartTextReader reader = new SmartTextReader();
char[][] data = reader.ReadFile(filePath);
ReadFileDataToConsole(data);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n--- Checker Proxy ---");
Console.ResetColor();
ISmartTextReader checker = new SmartTextChecker(reader);
checker.ReadFile(filePath);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- Locker Proxy (allowed) ---");
Console.ResetColor();
ISmartTextReader locker = new SmartTextReaderLocker(reader, @"forbidden\.txt");
data = locker.ReadFile(filePath);
ReadFileDataToConsole(data);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n--- Locker Proxy (denied) ---");
Console.ResetColor();
data = locker.ReadFile("forbidden.txt");
ReadFileDataToConsole(data);

void ReadFileDataToConsole(char[][] data)
{
    foreach (var line in data)
    {
        Console.WriteLine(new string(line));
    }
}