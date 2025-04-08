using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Flyweight
{
    public class LightTextNode : LightNode
    {
        private string TextContent { get; }

        public LightTextNode(string text)
        {
            TextContent = text;
        }
        public override string OuterHTML => TextContent;
        public override string InnerHTML => TextContent;
    }
}
