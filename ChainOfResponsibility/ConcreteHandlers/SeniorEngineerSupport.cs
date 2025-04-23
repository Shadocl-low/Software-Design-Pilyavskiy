using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandlers
{
    class SeniorEngineerSupport : SupportHandler
    {
        public override bool Handle(string request)
        {
            switch (request)
            {
                case "1":
                    Console.WriteLine("Senior Engineer: This might be a hardware failure. We recommend a diagnostics session.");
                    break;
                case "2":
                    Console.WriteLine("Senior Engineer: We can patch the kernel or review source-level code if needed.");
                    break;
                case "3":
                    Console.WriteLine("Senior Engineer: We’ll compile and install open-source drivers for your specific Ubuntu version.");
                    break;
                default:
                    Console.WriteLine("Senior Engineer: The issue is unclear. Please provide detailed logs.");
                    return false;
            }

            if (AskIfResolved())
            {
                return true;
            }

            return false;
        }
    }
}
