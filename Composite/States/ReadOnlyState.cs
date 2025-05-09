using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public class ReadOnlyState : EditState
    {
        public ReadOnlyState(LightNode node) : base(node) { }
        public override void AddChild(LightNode node) 
        {
            WriteColoredMessage($"Node is read-only. Cannot add child.", ErrorColor);
        }

        public override void AddChildByIndex(int index, LightNode node)
        {
            WriteColoredMessage($"Node is read-only. Cannot add child with id.", ErrorColor);
        }

        public override void AddClass(string className)
        {
            WriteColoredMessage($"Node is read-only. Cannot add class.", ErrorColor);
        }

        public override void RemoveClass(string className)
        {
            WriteColoredMessage($"Node is read-only. Cannot remove class.", ErrorColor);
        }

        public override void RemoveChild(LightNode node)
        {
            WriteColoredMessage($"Node is read-only. Cannot remove child.", ErrorColor);
        }

        public override void RemoveChildByIndex(int index)
        {
            WriteColoredMessage($"Node is read-only. Cannot remove child with id.", ErrorColor);
        }

        public override void SetTextContent(string text)
        {
            WriteColoredMessage($"Node is read-only. Cannot set text content.", ErrorColor);
        }
    }
}
