using Flyweight.Enums;

namespace Flyweight
{
    public class LightElementNode : LightNode
    {
        public TagType Tag { get; }
        private List<LightNode> Children { get; } = new();

        public LightElementNode(TagType tag)
        {
            Tag = tag;
        }
        public LightElementNode(string tag)
        {
            Tag = new TagType(tag);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public int ChildCount => Children.Count;

        public override string InnerHTML => string.Join("", Children.Select(child => child.OuterHTML));

        public override string OuterHTML
        {
            get 
            {
                string openingTag = $"<{Tag.Name}>";
                string closingTag = $"</{Tag.Name}>";

                string childrenHTML = string.Join("\n", Children.Select(child => child.OuterHTML));

                return Tag.Name=="html" ? $"{openingTag}\n{childrenHTML}\n{closingTag}" : $"{openingTag}{childrenHTML}{closingTag}";
            }

        }
    }
}
