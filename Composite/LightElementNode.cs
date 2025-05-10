using Composite.Enums;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private string TagName { get; }
        private DisplayType Display { get; }
        private ClosingType Closing { get; }
        private List<string> CssClasses { get; }
        private List<LightNode> Children { get; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
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

        protected override void OnCreated()
        {
            Console.WriteLine($"Element <{TagName}> created.");
        }

        protected override void OnClassListApplied()
        {
            if (CssClasses.Count > 0)
            {
                Console.WriteLine($"Class list applied to <{TagName}>: {string.Join(" ", CssClasses)}");
            }
        }

        protected override void OnChildrenInitialized()
        {
            foreach (var child in Children)
            {
                child.LifeCycle();
            }
        }

        public override void OnRemoved()
        {
            Console.WriteLine($"Element <{TagName}> removed.");
            foreach (var child in Children)
            {
                child.OnRemoved();
            }
        }
    }
}
