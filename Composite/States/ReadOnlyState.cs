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
            WriteError($"Node is read-only. Cannot add child.");
        }

        public override void AddChild(int index, LightNode node)
        {
            WriteError($"Node is read-only. Cannot add child with id.");
        }

        public override void AddClass(string className)
        {
            WriteError($"Node is read-only. Cannot add class.");
        }

        public override void RemoveClass(string className)
        {
            WriteError($"Node is read-only. Cannot remove class.");
        }

        public override void RemoveChild(LightNode node)
        {
            WriteError($"Node is read-only. Cannot remove child.");
        }

        public override void RemoveChild(int index)
        {
            WriteError($"Node is read-only. Cannot remove child with id.");
        }

        public override void SetTextContent(string text)
        {
            WriteError($"Node is read-only. Cannot set text content.");
        }
    }
}
