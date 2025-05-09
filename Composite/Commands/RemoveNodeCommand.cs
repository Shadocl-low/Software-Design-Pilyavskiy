using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class RemoveNodeCommand : ICommand
    {
        private List<LightNode> _container;
        private LightNode _node;
        private int _index;

        public RemoveNodeCommand(List<LightNode> container, LightNode node)
        {
            _container = container;
            _node = node;
        }

        public void Execute()
        {
            _index = _container.IndexOf(_node);
            if (_index >= 0) _container.RemoveAt(_index);
        }

        public void Undo()
        {
            _container.Insert(_index, _node);
        }
    }
}
