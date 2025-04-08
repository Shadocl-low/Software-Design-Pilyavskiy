using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            return lines.Select(line => line.ToCharArray()).ToArray();
        }
    }
}
