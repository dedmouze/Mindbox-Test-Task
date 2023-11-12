using Shapes.Abstractions;
using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Rectangle : Shape2D, IRectangle
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height, double area, double perimeter) : base (area, perimeter)
        {
            Width = width;
            Height = height;
        }
        public override string ToString() =>
            $"Прямоугольник со сторонами = {Width} и {Height}, площадью = {Area} и периметром = {Perimeter}";
    }
}
