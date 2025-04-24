using Composite.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightImageNode : LightNode
    {
        private readonly string href;
        private readonly IImageLoadingStrategy? loadingStrategy;

        public LightImageNode(string href)
        {
            this.href = href;
            this.loadingStrategy = DetermineStrategy(href);
        }
        private IImageLoadingStrategy DetermineStrategy(string href)
        {
            if (href.StartsWith("http://") || href.StartsWith("https://"))
                return new NetworkImageLoadingStrategy();

            return new FileImageLoadingStrategy();
        }
        public override string InnerHTML => "";

        public override string OuterHTML(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * indentStrenght);
            string? result = loadingStrategy?.Load(href);
            return $"{indent}<img src=\"{href}\" /> // {result}";
        }
    }
}
