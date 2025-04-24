using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Strategies
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public string Load(string href)
        {
            return $"[Loaded image from file: {href}]";
        }
    }
}
