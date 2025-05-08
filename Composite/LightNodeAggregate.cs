using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface LightNodeAggregate : IEnumerable
    {
        public new IEnumerator GetEnumerator();
    }
}
