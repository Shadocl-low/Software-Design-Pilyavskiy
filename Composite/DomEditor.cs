using Composite.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public static class DomEditor
    {
        private static List<LightNode> Container = new List<LightNode>();

        public static void AddNode(LightNode node)
        {
            var command = new AddNodeCommand(Container, node);
            ExecuteCommand(command);
        }
        public static void AddClass(LightElementNode element, string className)
        {
            var command = new AddClassCommand(element, className);
            ExecuteCommand(command);
        }
        public static void AppendChild(LightElementNode parent, LightNode child)
        {
            var command = new AppendChildCommand(parent, child);
            ExecuteCommand(command);
        }
        public static void RemoveNode(LightNode node)
        {
            var command = new RemoveNodeCommand(Container, node);
            ExecuteCommand(command);
        }
        public static void ReplaceText(LightTextNode node, string newText)
        {
            var command = new ReplaceTextCommand(node, newText);
            ExecuteCommand(command);
        }
        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            CommandsHistory.Push(command);
        }
        public static void Undo()
        {
            var command = CommandsHistory.Pop();
            command?.Undo();
        }
        public static void ShowAllTagsInDomConsole()
        {
            Console.WriteLine($"\nDOM:");
            foreach (var node in Container)
            {
                Console.WriteLine(node);
            }
        }
    }
}
