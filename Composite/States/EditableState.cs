using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public class EditableState : EditState
    {
        public EditableState(LightNode node) : base(node) { }
        public override void AddChild(LightNode node)
        {
            if (Node is LightElementNode elementNode)
                elementNode.Children.Add(node);
        }

        public override void AddChild(int index, LightNode node)
        {
            if (Node is LightElementNode elementNode)
                elementNode.Children.Insert(index, node);
        }

        public override void AddClass(string className)
        {
            if (Node is LightElementNode elementNode)
                elementNode.CssClasses.Add(className);
        }

        public override void RemoveClass(string className)
        {
            if (Node is LightElementNode elementNode)
                elementNode.CssClasses.Remove(className);
        }

        public override void RemoveChild(LightNode node)
        {
            if (Node is LightElementNode elementNode)
                elementNode.Children.Remove(node);
        }

        public override void RemoveChild(int index)
        {
            if (Node is LightElementNode elementNode)
                elementNode.Children.RemoveAt(index);
        }

        public override void SetTextContent(string text)
        {
            if (Node is LightTextNode textNode)
                textNode.TextContent = text;
        }
    }
}
