using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Triangle : Shape
    {
        private float baseLength;
        private float height;

        public Triangle(IRenderer renderer, float baseLength, float height) : base(renderer)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle {renderer.Render()} (with base lenght {baseLength} and height {height})");
        }
    }
}
