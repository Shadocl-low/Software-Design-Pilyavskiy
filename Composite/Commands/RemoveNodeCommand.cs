using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class RemoveNodeCommand : ICommand
    {
        private List<LightNode> Nodes;
        private LightNode Node;
        private int Index;

        public RemoveNodeCommand(List<LightNode> nodes, LightNode node)
        {
            Nodes = nodes;
            Node = node;
        }

        public void Execute()
        {
            Index = Nodes.IndexOf(Node);
            if (Index >= 0) Nodes.RemoveAt(Index);
        }

        public void Undo()
        {
            Nodes.Insert(Index, Node);
        }
    }
}
