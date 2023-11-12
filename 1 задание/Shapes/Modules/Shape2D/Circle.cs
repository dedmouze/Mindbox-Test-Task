using Shapes.Abstractions;
using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Circle : Shape2D, ICircle
    {
        public double Radius { get; }
        public Circle(double radius, double area, double perimeter) : base(area, perimeter) => Radius = radius;
        public override string ToString() =>
            $"Круг с радиусом = {Radius}, площадью = {Area} и периметром = {Perimeter}";
    }
}
