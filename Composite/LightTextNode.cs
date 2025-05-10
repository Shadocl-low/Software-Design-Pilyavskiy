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
        private string TextContent { get; }

        public LightTextNode(string text)
        {
            TextContent = text;
        }
        public override string OuterHTML(int indentLevel = 0) => new string(' ', indentLevel * 4) + TextContent;
        public override string InnerHTML => TextContent;

        protected override void OnCreated()
        {
            Console.WriteLine($"Text node created: \"{TextContent}\"");
        }

        public override void OnRemoved()
        {
            Console.WriteLine($"Text node removed: \"{TextContent}\"");
        }
    }
}
