using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    public class EUR : Money
    {
        public EUR(long euros, int cents) : base(euros, cents, "EUR")
        {
        }
    }
}
