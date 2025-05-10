using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML(int indentLevel = 0);
        public abstract string InnerHTML { get; }

        public void LifeCycle()
        {
            OnBeforeCreated();
            OnCreated();
            OnClassListApplied();
            OnChildrenInitialized();
            OnAfterCreated();
        }

        protected void OnBeforeCreated() 
        {
            Console.WriteLine($"New LightNode element will be created");
        }
        protected virtual void OnCreated() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnChildrenInitialized() { }
        protected void OnAfterCreated()
        {
            Console.WriteLine($"New LightNode element was created");
        }

        public virtual void OnRemoved() { }
    }
}
