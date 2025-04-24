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
        public EventManager Events { get; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            Events = new EventManager();
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
            Events.Notify(EventType.AddClass, $"Was added class {className} on <{TagName}>");
        }
        public void RemoveClass(string className)
        {
            CssClasses.Remove(className);
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
            Events.Notify(EventType.AddChild, $"Was added child to {TagName}");
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

        public void ClickTag()
        {
            var eventInfo = $"<{TagName}> was clicked. ";

            if (!CssClasses.Contains("active"))
            {
                AddClass("active");
                eventInfo += $"<{TagName}> is now active";
            }
            else
            {
                RemoveClass("active");
                eventInfo += $"<{TagName}> is now inactive";
            }

            Events.Notify(EventType.Click, eventInfo);
        }

        public void AddEventListner(EventType eventType, IEventListener listener)
        {
            Events.Subscribe(eventType, listener);
        }
    }
}
