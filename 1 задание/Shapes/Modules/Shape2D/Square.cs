using Shapes.Abstractions;
using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Square : Shape2D, ISquare
    {
        public double Side { get; }
        public Square(double side, double area, double perimeter) : base(area, perimeter) => Side = side;
        public override string ToString() =>
            $"Квадрат со стороной = {Side}, площадью = {Area} и периметром = {Perimeter}";
    }
}
