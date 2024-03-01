using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Rectangle : IRectangle
    {
        public double Perimeter { get; }
        public double Area { get; }
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height, double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
            Width = width;
            Height = height;
        }
        public override string ToString() =>
            $"Прямоугольник со сторонами = {Width} и {Height}, площадью = {Area} и периметром = {Perimeter}";
    }
}
