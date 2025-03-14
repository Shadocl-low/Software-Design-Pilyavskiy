using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    public class USD : Money
    {
        public USD(long dollars, int cents) : base(dollars, cents, "USD")
        {
        }
    }
}
