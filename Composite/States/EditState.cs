using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public abstract class EditState
    {
        protected LightNode Node;
        public EditState(LightNode node) => Node = node;

        public void SetNode(LightNode node)
        {
            Node = node;
        }
        public abstract void AddClass(string className);
        public abstract void RemoveClass(string className);
        public abstract void AddChild(LightNode node);
        public abstract void AddChild(int index, LightNode node);
        public abstract void RemoveChild(LightNode node);
        public abstract void RemoveChild(int index);
        public abstract void SetTextContent(string text);
    }
}
