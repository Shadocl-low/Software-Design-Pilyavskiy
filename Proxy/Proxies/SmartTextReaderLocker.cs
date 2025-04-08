using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy.Proxies
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly SmartTextReader _reader;
        private readonly Regex _deniedPattern;

        public SmartTextReaderLocker(SmartTextReader reader, string regex)
        {
            _reader = reader;
            _deniedPattern = new Regex(regex, RegexOptions.IgnoreCase);
        }

        public char[][] ReadFile(string filePath)
        {
            if (_deniedPattern.IsMatch(filePath))
            {
                string[] message = new[] { $"Access denied to file: {filePath}" };
                return message.Select(line => line.ToCharArray()).ToArray();
            }

            return _reader.ReadFile(filePath);
        }
    }
}
