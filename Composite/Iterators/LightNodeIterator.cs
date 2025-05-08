using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Iterators
{
    public abstract class LightNodeIterator : IEnumerator
    {
        object IEnumerator.Current => Current!;
        public LightNode? Current { get; set; }
        public abstract bool MoveNext();
        public void Reset() { }
    }
}
