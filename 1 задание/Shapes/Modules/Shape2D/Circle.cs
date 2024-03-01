using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Circle : ICircle
    {
        public double Perimeter { get; }
        public double Area { get; }
        public double Radius { get; }

        public Circle(double radius, double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
            Radius = radius;
        }
        public override string ToString() =>
            $"Круг с радиусом = {Radius}, площадью = {Area} и периметром = {Perimeter}";
    }
}
