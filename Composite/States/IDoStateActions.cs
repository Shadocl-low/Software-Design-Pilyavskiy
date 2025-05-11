using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.States
{
    public interface IDoStateActions
    {
        public void AddClass(string className);
        public void RemoveClass(string className);
        public void AddChild(LightNode node);
        public void AddChildByIndex(int index, LightNode node);
        public void RemoveChild(LightNode node);
        public void RemoveChildByIndex(int index);
        public void SetTextContent(string text);
    }
}
