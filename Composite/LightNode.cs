using Composite.States;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightNode : IDoStateActions
    {
        public abstract string OuterHTML(int indentLevel = 0);
        public abstract string InnerHTML { get; }
        protected EditState State;
        protected LightNode()
        {
            State = new EditableState(this);
        }
        protected LightNode(EditState state)
        {
            State = state;
        }
        public void SetState(EditState state)
        {
            State = state;
        }
        public void SetEditableState()
        {
            State = new EditableState(this);
        }
        public void SetReadOnlyState()
        {
            State = new ReadOnlyState(this);
        }
        public void SetLockedState(User user)
        {
            State = new LockedState(this, user);
        }

        public virtual void AddClass(string className) { }
        public virtual void RemoveClass(string className) { }
        public virtual void AddChild(LightNode node) { }
        public virtual void AddChildByIndex(int index, LightNode node) { }
        public virtual void RemoveChild(LightNode node) { }
        public virtual void RemoveChildByIndex(int index) { }
        public virtual void SetTextContent(string text) { }

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
