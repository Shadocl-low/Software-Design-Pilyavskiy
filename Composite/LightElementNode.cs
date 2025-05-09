using Composite.Enums;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private string TagName { get; }
        private DisplayType Display { get; }
        private ClosingType Closing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing) : base()
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public override void AddClass(string className) => State.AddClass(className);
        public override void RemoveClass(string className) => State.RemoveClass(className);
        public override void AddChild(LightNode node) => State.AddChild(node);
        public override void AddChildByIndex(int index, LightNode node) => State.AddChildByIndex(index, node);
        public override void RemoveChild(LightNode node) => State.RemoveChild(node);
        public override void RemoveChildByIndex(int index) => State.RemoveChildByIndex(index);

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
        public override string ToString()
        {
            string classString = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            return $"Element - {TagName}{classString}";
        }
    }
}
