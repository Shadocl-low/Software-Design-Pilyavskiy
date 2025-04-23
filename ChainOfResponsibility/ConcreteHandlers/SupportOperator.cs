using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandlers
{
    class SupportOperator : SupportHandler
    {
        public override bool Handle(string request)
        {
            switch (request)
            {
                case "1":
                    Console.WriteLine("Support Operator: Have you checked the power cable and the monitor connection?");
                    break;
                case "2":
                    Console.WriteLine("Support Operator: Please try updating the application or check logs for specific errors.");
                    break;
                case "3":
                    return ConnectWithNextOperator(request, "Support Operator: Wait a second, we'll connect you with our engineer.");
                default:
                    Console.WriteLine("Support Operator: Invalid option. Please select a valid issue type.");
                    break;
            }

            if (AskIfResolved())
            {
                return true;
            }

            return ConnectWithNextOperator(request, "Connecting the engineer...");
        }
    }
}
