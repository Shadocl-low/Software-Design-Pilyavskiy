using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class AppendChildCommand : ICommand
    {
        private LightElementNode Parent;
        private LightNode Child;

        public AppendChildCommand(LightElementNode parent, LightNode child)
        {
            Parent = parent;
            Child = child;
        }

        public void Execute()
        {
            Parent.AddChild(Child);
        }

        public void Undo()
        {
            Parent.RemoveChild(Child);
        }
    }
}
