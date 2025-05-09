using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class AppendChildCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;

        public AppendChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.AddChild(_child);
        }

        public void Undo()
        {
            _parent.RemoveChild(_child);
        }
    }
}
