using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {
        private string _content;

        public TextDocument(string content = "")
        {
            _content = content + " ";
        }
        public void Write(string text)
        {
            _content += text + " ";
        }
        public void Erase()
        {
            _content = "";
        }
        public IMemento Save()
        {
            return new DocumentMemento(_content);
        }
        public void Restore(IMemento memento)
        {
            if (memento is DocumentMemento documentMemento)
            {
                _content = documentMemento.GetState();
            }
        }
        public string GetContent()
        {
            return _content;
        }
    }
}
