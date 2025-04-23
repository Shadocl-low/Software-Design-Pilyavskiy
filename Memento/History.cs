using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class History
    {
        private readonly Stack<IMemento> _mementos = new Stack<IMemento>();

        public void Save(IMemento memento)
        {
            _mementos.Push(memento);
        }
        public IMemento? Undo()
        {
            if (_mementos.Count > 0)
                return _mementos.Pop();
            return null;
        }
        public void ShowHistory()
        {
            Console.WriteLine("History of states:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine($"Backup State: {memento.GetState()}/ Date: {memento.GetDate()}");
            }
        }
    }
}
