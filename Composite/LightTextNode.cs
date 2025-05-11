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
        public string TextContent { get; set; }

        public LightTextNode(string text) : base()
        {
            TextContent = text;

            DomEditor.AddNode(this);
        }
        public override string OuterHTML(int indentLevel = 0) => new string(' ', indentLevel * 4) + TextContent;
        public override string InnerHTML => TextContent;
        public override string ToString()
        {
            return $"Text - {TextContent}";
        }
        public override void SetTextContent(string text) => State.SetTextContent(text);

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
