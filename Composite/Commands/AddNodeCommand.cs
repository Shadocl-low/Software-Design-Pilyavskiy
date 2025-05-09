using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class AddNodeCommand : ICommand
    {
        private List<LightNode> _container;
        private LightNode _node;

        public AddNodeCommand(List<LightNode> container, LightNode node)
        {
            _container = container;
            _node = node;
        }

        public void Execute()
        {
            _container.Add(_node);
        }

        public void Undo()
        {
            _container.Remove(_node);
        }
    }
}
