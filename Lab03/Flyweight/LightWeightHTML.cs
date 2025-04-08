using Flyweight.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightWeightHTML
    {
        private readonly Dictionary<string, TagType> _tagCache = new();

        public TagType GetTagType(string tagName)
        {
            if (!_tagCache.TryGetValue(tagName, out var tagType))
            {
                tagType = new TagType(tagName);
                _tagCache[tagName] = tagType;
            }
            return tagType;
        }

        public LightElementNode CreateElement(string tagName, string text)
        {
            var tagType = GetTagType(tagName);
            var element = new LightElementNode(tagType);
            element.AddChild(new LightTextNode(text));
            return element;
        }

        public int GetCacheCount() => _tagCache.Count;
    }
}
