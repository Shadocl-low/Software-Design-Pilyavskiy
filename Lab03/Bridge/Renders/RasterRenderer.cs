using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renders
{
    class RasterRenderer : IRenderer
    {
        public string Render() => "as pixel";
    }
}
