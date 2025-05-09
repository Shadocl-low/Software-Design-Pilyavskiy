using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public class LockedState : EditableState
    {
        private readonly User StateUser;
        private bool Locked = true;
        public LockedState(LightNode node, User user) : base(node) => StateUser = user;
        public override void AddChild(LightNode node)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot add child.");
        }

        public override void AddChild(int index, LightNode node)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot add child with id.");
        }

        public override void AddClass(string className)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot add class.");
        }

        public override void RemoveClass(string className)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot remove class.");
        }

        public override void RemoveChild(LightNode node)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot remove child.");
        }

        public override void RemoveChild(int index)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot remove child with id.");
        }

        public override void SetTextContent(string text)
        {
            HandleAutorization($"Node is locked, please autorize as admin. Cannot set text content.");
        }
        public void CheckAutorization()
        {                    
            Locked = !StateUser.Autorize();
        }
        private void HandleAutorization(string message)
        {
            CheckAutorization();

            if (Locked) WriteError(message);
            else Node.SetState(new EditableState(Node));
        }
    }
}
