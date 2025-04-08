using Adapter;

Console.WriteLine("Console Logger:");
Logger consoleLogger = new Logger();
consoleLogger.Log("This is a log message.");
consoleLogger.Error("This is an error message.");
consoleLogger.Warn("This is a warning message.");

Console.WriteLine("\nFile Logger:");
var fileLogger = new FileLoggerAdapter("log.txt");
fileLogger.Log("This is a log message to file.");
fileLogger.Error("This is an error message to file.");
fileLogger.Warn("This is a warning message to file.");

Console.WriteLine("Log written to 'log.txt'.");
