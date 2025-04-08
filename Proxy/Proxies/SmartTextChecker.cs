using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxies
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[][] result = Array.Empty<char[]>();

            try
            {
                result = _reader.ReadFile(filePath);
                Console.WriteLine("File read successfully.");

                int lineCount = result.Length;
                int charCount = result.Sum(line => line.Length);

                Console.WriteLine($"Total lines: {lineCount}");
                Console.WriteLine($"Total characters: {charCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Closing file: {filePath}");
            }

            return result;
        }
    }
}
