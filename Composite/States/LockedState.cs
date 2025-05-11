using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
            HandleAutorization(lnode: node, errorMessage: $"Node is locked, please autorize as admin. Cannot add child.");
        }

        public override void AddChildByIndex(int index, LightNode node)
        {
            HandleAutorization(index: index, lnode: node, errorMessage: $"Node is locked, please autorize as admin. Cannot add child with id.");
        }

        public override void AddClass(string className)
        {
            HandleAutorization(str: className, errorMessage: $"Node is locked, please autorize as admin. Cannot add class.");
        }

        public override void RemoveClass(string className)
        {
            HandleAutorization(str: className, errorMessage: $"Node is locked, please autorize as admin. Cannot remove class.");
        }

        public override void RemoveChild(LightNode node)
        {
            HandleAutorization(lnode: node, errorMessage: $"Node is locked, please autorize as admin. Cannot remove child.");
        }

        public override void RemoveChildByIndex(int index)
        {
            HandleAutorization(index: index, errorMessage: $"Node is locked, please autorize as admin. Cannot remove child with id.");
        }

        public override void SetTextContent(string text)
        {
            HandleAutorization(str: text, errorMessage: $"Node is locked, please autorize as admin. Cannot set text content.");
        }
        public void CheckAutorization()
        {
            Locked = !StateUser.Autorize();
        }
        private void HandleAutorization(string errorMessage, string? str = null, int? index = null, LightNode? lnode = null, [CallerMemberName] string caller = "")
        {
            CheckAutorization();

            if (Locked) WriteColoredMessage(errorMessage, ErrorColor);
            else
            {
                WriteColoredMessage($"Autorization successful, state was changed to Editable", SuccessColor);

                Node.SetEditableState();

                var argumentValues = GetMethodArguments(str, index, lnode);

                var method = Node.GetType().GetMethod(caller);

                method?.Invoke(Node, argumentValues);
            }
        }
        private object[] GetMethodArguments(string? str, int? index, LightNode? lnode)
        {
            var arguments = new List<object>();

            if (str != null) arguments.Add(str);
            else if (index.HasValue) arguments.Add(index.Value);
            else if (lnode != null) arguments.Add(lnode);

            return arguments.ToArray();
        }
    }
}
