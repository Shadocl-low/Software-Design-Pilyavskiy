using Composite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DomEditor
    {
        private Stack<ICommand> History = new Stack<ICommand>();
        private List<LightNode> Container = new List<LightNode>();

        public void AddNode(LightNode node)
        {
            var command = new AddNodeCommand(Container, node);
            ExecuteCommand(command);
        }
        public void AddClass(LightElementNode element, string className)
        {
            var command = new AddClassCommand(element, className);
            ExecuteCommand(command);
        }
        public void RemoveNode(LightNode node)
        {
            var command = new RemoveNodeCommand(Container, node);
            ExecuteCommand(command);
        }
        public void ReplaceText(LightTextNode node, string newText)
        {
            var command = new ReplaceTextCommand(node, newText);
            ExecuteCommand(command);
        }
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            History.Push(command);
        }
        public void Undo()
        {
            if (History.Count > 0)
            {
                var command = History.Pop();
                command.Undo();
            }
        }
    }
}
