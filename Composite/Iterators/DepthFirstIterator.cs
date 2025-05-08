using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public class DepthFirstIterator : LightNodeIterator
    {
        private readonly Stack<LightNode> _stack = new();

        public DepthFirstIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public override bool MoveNext()
        {
            if (_stack.Count == 0) return false;

            Current = _stack.Pop();

            if (Current is LightElementNode element)
            {
                for (int i = element.ChildCount - 1; i >= 0; i--)
                {
                    _stack.Push(element.GetChild(i));
                }
            }

            return true;
        }
    }
}
