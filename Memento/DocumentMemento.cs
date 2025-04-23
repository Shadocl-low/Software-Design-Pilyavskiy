using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Memento
{
    public class DocumentMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _date;

        public DocumentMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }
        public string GetState()
        {
            return _state;
        }
        public DateTime GetDate()
        {
            return _date;
        }
    }
}
