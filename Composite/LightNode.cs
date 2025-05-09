using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightNode
    {
        public DomEditor dom = new();
        public abstract string OuterHTML(int indentLevel = 0);
        public abstract string InnerHTML { get; }
    }
}
