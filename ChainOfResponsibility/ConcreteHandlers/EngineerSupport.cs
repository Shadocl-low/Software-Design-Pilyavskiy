using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandlers
{
    class EngineerSupport : SupportHandler
    {
        public override bool Handle(string request)
        {
            switch (request)
            {
                case "1":
                    Console.WriteLine("Engineer: We may need to check the motherboard or PSU. Can you access BIOS?");
                    break;
                case "2":
                    Console.WriteLine("Engineer: Let’s analyze crash dumps and debug logs for root causes.");
                    break;
                case "3":
                    Console.WriteLine("Engineer: Please download the latest drivers from the manufacturer’s site.");
                    break;
                default:
                    Console.WriteLine("Support Operator: Invalid option. Please select a valid issue type.");
                    break;
            }

            if (AskIfResolved())
            {
                return true;
            }

            return ConnectWithNextOperator(request, "Connecting the senior...");
        }
    }
}
