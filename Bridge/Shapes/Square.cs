using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Square : Shape
    {
        private float sideLength;

        public Square(IRenderer renderer, float sideLength) : base(renderer)
        {
            this.sideLength = sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Square {renderer.Render()} (with side {sideLength})");
        }
    }
}
