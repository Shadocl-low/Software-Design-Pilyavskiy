using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    public class UAH : Money
    {
        public UAH(long hryvnias, int kopiykas) : base(hryvnias, kopiykas, "UAH")
        {
        }
    }
}
