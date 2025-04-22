using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class SupportHandler : IHandler
    {
        protected IHandler? nextHandler;

        public void SetNext(IHandler next)
        {
            nextHandler = next;
        }
        public bool AskIfResolved()
        {
            Console.WriteLine("\nDid this solution help you? (yes/no): ");
            string? response = Console.ReadLine()?.Trim().ToLower();

            return response == "yes";
        }
        public bool ConnectWithNextOperator(string request, string message)
        {
            Console.WriteLine($"\n{message}");
            return nextHandler != null && nextHandler.Handle(request);

        }
        public abstract bool Handle(string issue);
    }
}
