using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class AddNodeCommand : ICommand
    {
        private List<LightNode> Nodes;
        private LightNode Node;

        public AddNodeCommand(List<LightNode> nodes, LightNode node)
        {
            Nodes = nodes;
            Node = node;
        }

        public void Execute()
        {
            Nodes.Add(Node);
        }

        public void Undo()
        {
            Nodes.Remove(Node);
        }
        public override string ToString()
        {
            return $"Command: Add Node";
        }
    }
}
