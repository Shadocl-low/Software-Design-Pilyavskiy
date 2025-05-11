using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public abstract class EditState : IDoStateActions
    {
        protected LightNode Node;
        protected ConsoleColor ErrorColor = ConsoleColor.Red;
        protected ConsoleColor SuccessColor = ConsoleColor.Green;
        public EditState(LightNode node) => Node = node;

        public void SetNode(LightNode node)
        {
            Node = node;
        }
        public abstract void AddClass(string className);
        public abstract void RemoveClass(string className);
        public abstract void AddChild(LightNode node);
        public abstract void AddChildByIndex(int index, LightNode node);
        public abstract void RemoveChild(LightNode node);
        public abstract void RemoveChildByIndex(int index);
        public abstract void SetTextContent(string text);
        protected void WriteColoredMessage(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
