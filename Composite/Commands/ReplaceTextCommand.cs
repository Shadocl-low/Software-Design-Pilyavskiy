using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class ReplaceTextCommand : ICommand
    {
        private LightTextNode Node;
        private string NewText;
        private string OldText;

        public ReplaceTextCommand(LightTextNode node, string newText)
        {
            Node = node;
            NewText = newText;
            OldText = string.Empty;
        }

        public void Execute()
        {
            OldText = Node.TextContent;
            Node.SetTextContent(NewText);
        }

        public void Undo()
        {
            Node.SetTextContent(OldText);
        }
    }
}
