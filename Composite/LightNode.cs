using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightNode
    {
        protected int indentStrenght = 4;
        public abstract string OuterHTML(int indentLevel = 0);
        public abstract string InnerHTML { get; }
    }
}
