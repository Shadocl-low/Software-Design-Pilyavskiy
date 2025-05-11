using Composite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public static class CommandsHistory
    {
        private static readonly Stack<ICommand> History = new Stack<ICommand>();

        public static ICommand? Pop()
        {
            if (History.Count > 0)
            {
                return History.Pop();
            }

            return null;
        }

        public static void Push(ICommand command)
        {
            History.Push(command);
        }

        public static void ShowHistoryConsole()
        {
            Console.WriteLine($"\nHistory:");
            foreach (var item in History)
            {
                Console.WriteLine(item);
            }
        }
    }
}
