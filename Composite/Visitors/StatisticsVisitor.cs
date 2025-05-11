using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Visitors
{
    public class StatisticsVisitor : ILightNodeVisitor
    {
        public int TextNodeCount { get; private set; } = 0;
        public int ElementNodeCount { get; private set; } = 0;

        public Dictionary<string, int> TagCounts { get; private set; } = new();
        public HashSet<string> ClassNames { get; private set; } = new();

        public void VisitElement(LightElementNode element)
        {
            ElementNodeCount++;

            if (TagCounts.ContainsKey(element.TagName))
                TagCounts[element.TagName]++;
            else
                TagCounts[element.TagName] = 1;

            foreach (var className in element.CssClasses)
            {
                ClassNames.Add(className);
            }

            foreach (var child in element.Children)
            {
                child.Accept(this);
            }
        }

        public void VisitText(LightTextNode text)
        {
            TextNodeCount++;
        }
        public void WriteConsoleStatistics()
        {
            Console.WriteLine("\nStatistics:");
            Console.WriteLine($"Text nodes: {TextNodeCount}");
            Console.WriteLine($"Element nodes: {ElementNodeCount}");
            Console.WriteLine("Tag counts:");
            foreach (var kvp in TagCounts)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine("Unique classes:");
            foreach (var className in ClassNames)
            {
                Console.WriteLine($"  {className}");
            }
        }
    }
}
