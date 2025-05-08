using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public class BreadthFirstIterator : LightNodeIterator
    {
        private readonly Queue<LightNode> _queue = new();

        public BreadthFirstIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public override bool MoveNext()
        {
            if (_queue.Count == 0) return false;

            Current = _queue.Dequeue();

            if (Current is LightElementNode element)
            {
                for (int i = 0; i < element.ChildCount; i++)
                {
                    _queue.Enqueue(element.GetChild(i));
                }
            }

            return true;
        }
    }
}
