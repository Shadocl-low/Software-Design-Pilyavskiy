using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Commands
{
    public class ReplaceTextCommand : ICommand
    {
        private LightTextNode _node;
        private string _newText;
        private string _oldText;

        public ReplaceTextCommand(LightTextNode node, string newText)
        {
            _node = node;
            _newText = newText;
            _oldText = string.Empty;
        }

        public void Execute()
        {
            _oldText = _node.TextContent;
            _node.SetTextContent(_newText);
        }

        public void Undo()
        {
            _node.SetTextContent(_oldText);
        }
    }
}
