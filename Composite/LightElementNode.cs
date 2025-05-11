using Composite.Enums;
using Composite.Iterators;
using System.Collections;

namespace Composite
{
    public class LightElementNode : LightNode, LightNodeAggregate
    {
        private string TagName { get; }
        private DisplayType Display { get; }
        private ClosingType Closing { get; }
        private List<string> CssClasses { get; }
        private List<LightNode> Children { get; }
        private LightNodeIterator? Iterator { get; set; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();

            SetBreadthFirstEnumerator();

            DomEditor.AddNode(this);
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }
        public void RemoveClass(string className)
        {
            CssClasses.Remove(className);
        }
        public bool ContainsClass(string className)
        {
            return CssClasses.Contains(className);
        }
        public void AddChild(LightNode node)
        {
            Children.Add(node);
        }
        public void AddChild(int index, LightNode node)
        {
            Children.Insert(index, node);
        }
        public void RemoveChild(LightNode node)
        {
            Children.Remove(node);
        }
        public void RemoveChild(int index)
        {
            Children.RemoveAt(index);
        }
        public int IndexOfChild(LightNode node)
        {
            return Children.IndexOf(node);
        }

        public int ChildCount => Children.Count;

        public override string InnerHTML => string.Join("", Children.Select(child => child.OuterHTML()));

        public override string OuterHTML(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 4);

            string classString = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            string openingTag = $"<{TagName}{classString}>";
            string closingTag = $"</{TagName}>";

            if (Closing == ClosingType.SelfClosing)
            {
                return $"{indent}<{TagName}{classString}/>";
            }

            string childrenHTML = string.Join("\n", Children.Select(child => child.OuterHTML(indentLevel + 1)));

            return $"{indent}{openingTag}\n{childrenHTML}\n{indent}{closingTag}";
        }
        public IEnumerator GetEnumerator() => Iterator!;
        public void SetDepthFirstEnumerator()
        {
            Iterator = new DepthFirstIterator(this);
        }
        public void SetBreadthFirstEnumerator()
        {
            Iterator = new BreadthFirstIterator(this);
        }
        public LightNode GetChild(int index) => Children[index];

        public override string ToString()
        {
            string classString = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            return $"Element - {TagName}{classString}";
        }
    }
}
