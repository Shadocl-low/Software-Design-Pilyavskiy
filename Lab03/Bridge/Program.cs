using Bridge.Renders;
using Bridge.Shapes;
using Bridge;

IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();

Shape circle = new Circle(vectorRenderer, 5);
Shape square = new Square(rasterRenderer, 10);
Shape triangle = new Triangle(vectorRenderer, 8, 6);

circle.Draw();
square.Draw();
triangle.Draw();