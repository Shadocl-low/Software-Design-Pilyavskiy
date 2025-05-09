using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Commands
{
    public class RemoveNodeCommand : ICommand
    {
        private List<LightNode> Nodes;
        private LightNode Node;
        private int Index;

        private LightElementNode? ParentElement;
        private int ChildIndex = -1;

        public RemoveNodeCommand(List<LightNode> nodes, LightNode node)
        {
            Nodes = nodes;
            Node = node;

            foreach (var potentialParent in nodes.OfType<LightElementNode>())
            {
                int idx = potentialParent.IndexOfChild(node);
                if (idx >= 0)
                {
                    ParentElement = potentialParent;
                    ChildIndex = idx;
                    break;
                }
            }
        }

        public void Execute()
        {
            Index = Nodes.IndexOf(Node);
            if (Index >= 0)
            {
                Nodes.RemoveAt(Index);
            }

            if (ParentElement != null && ChildIndex >= 0)
            {
                ParentElement.RemoveChild(ChildIndex);
            }
        }

        public void Undo()
        {
            if (Index >= 0)
            {
                Nodes.Insert(Index, Node);
            }

            if (ParentElement != null && ChildIndex >= 0)
            {
                ParentElement.AddChild(ChildIndex, Node);
            }
        }
        public override string ToString()
        {
            return $"Command: Remove Node";
        }
    }
}
