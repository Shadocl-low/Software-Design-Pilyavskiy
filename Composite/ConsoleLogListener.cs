using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ConsoleLogListener : IEventListener
    {
        private string prefix;
        private ConsoleColor logColor;

        public ConsoleLogListener(string prefix)
        {
            this.prefix = prefix;
            this.logColor = ConsoleColor.Blue;
        }

        public void Update(string eventData)
        {
            Console.ForegroundColor = logColor;
            Console.WriteLine($"{prefix}: Data — \"{eventData}\"");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
