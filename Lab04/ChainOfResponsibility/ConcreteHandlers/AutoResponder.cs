using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandlers
{
    class AutoResponder : SupportHandler
    {
        public override bool Handle(string request)
        {
            switch (request)
            {
                case "1":
                    Console.WriteLine("Auto-Responder: Please check if your computer is plugged in and the power button is functional.");
                    break;
                case "2":
                    Console.WriteLine("Auto-Responder: Try restarting the software or reinstalling it.");
                    break;
                case "3":
                    Console.WriteLine("Auto-Responder: Ensure you have the latest drivers installed.");
                    break;
                default:
                    Console.WriteLine("Auto-Responder: Invalid option. Please select a valid issue type.");
                    break;
            }

            if (AskIfResolved())
            {
                return true;
            }

            return ConnectWithNextOperator(request, "Connecting the operator...");
        }
    }
}
