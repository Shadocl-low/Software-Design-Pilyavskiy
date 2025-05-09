using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Composite
{
    public class LightTextNode : LightNode
    {
        public string TextContent { get; private set; }

        public LightTextNode(string text)
        {
            TextContent = text;

            dom.AddNode(this);
        }
        public override string OuterHTML(int indentLevel = 0) => new string(' ', indentLevel * 4) + TextContent;
        public override string InnerHTML => TextContent;
        public void SetTextContent(string text)
        {
            TextContent = text;
        }
    }
}
