using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TagType
    {
        public string Name { get; }
        public TagType(string name) => Name = name;
    }
}
