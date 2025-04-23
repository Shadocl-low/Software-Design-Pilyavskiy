using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly History _history;

        public TextEditor()
        {
            _document = new TextDocument();
            _history = new History();
        }
        public TextEditor(string content)
        {
            _document = new TextDocument(content);
            _history = new History();
        }
        public void Write(string text)
        {
            _history.Save(_document.Save());
            _document.Write(text);
        }
        public void Erase()
        {
            _history.Save(_document.Save());
            _document.Erase();
            Console.WriteLine("Content erased");
        }
        public void Undo()
        {
            var memento = _history.Undo();
            if (memento != null)
            {
                _document.Restore(memento);
                Console.WriteLine("Undo successful.");
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }
        public void ShowContent()
        {
            Console.WriteLine($"Document content: {_document.GetContent()}");
        }
        public void ShowHistory()
        {
            _history.ShowHistory();
        }
    }

}
