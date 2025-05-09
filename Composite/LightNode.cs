using Composite.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML(int indentLevel = 0);
        public abstract string InnerHTML { get; }
        protected EditState State;
        protected LightNode()
        {
            State = new EditableState(this);
        }
        protected LightNode(EditState state)
        {
            State = state;
        }
        protected void SetState(EditState state)
        {
            State = state;
        }
    }
}
