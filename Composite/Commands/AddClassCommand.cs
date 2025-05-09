using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class AddClassCommand : ICommand
    {
        private readonly LightElementNode Node;
        private readonly string ClassName;

        public AddClassCommand(LightElementNode element, string className)
        {
            Node = element;
            ClassName = className;
        }

        public void Execute()
        {
            if (!Node.ContainsClass(ClassName)) 
                Node.AddClass(ClassName);
        }

        public void Undo()
        {
            Node.RemoveClass(ClassName);
        }
    }
}
