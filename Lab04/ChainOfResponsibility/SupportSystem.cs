using ChainOfResponsibility.ConcreteHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class SupportSystem
    {
        private SupportHandler? handlerChain;
        private string title = "Please select the issue you're facing";
        private Dictionary<int, string> options = new Dictionary<int, string>() {
            { 1, "Computer won't start" },
            { 2, "Software crash" },
            { 3, "Driver issue" }
        };

        public SupportSystem()
        {
            BuildChain();
        }

        private void BuildChain()
        {
            var autoResponder = new AutoResponder();
            var supportOperator = new SupportOperator();
            var engineer = new EngineerSupport();
            var seniorEngineer = new SeniorEngineerSupport();

            autoResponder.SetNext(supportOperator);
            supportOperator.SetNext(engineer);
            engineer.SetNext(seniorEngineer);

            handlerChain = autoResponder;
        }

        public void Start()
        {
            var fixingProblem = true;
            while (fixingProblem)
            {
                ShowMenu(title, options);
                string? input = Console.ReadLine()?.Trim();

                if (!handlerChain!.Handle(input!))
                {
                    Console.WriteLine("\nInvalid selection or issue not resolved. Please try again.\n");
                }
                else
                {
                    fixingProblem = false;
                }
            }

            Console.WriteLine("\nThank you for using our line!");
        }

        private void ShowMenu(string title, Dictionary<int, string> options)
        {
            Console.WriteLine($"{title}:");
            foreach (var option in options)
            {
                Console.WriteLine($"{option.Key} - {option.Value}");
            }
            Console.Write("Your choice: ");
        }
    }
}
