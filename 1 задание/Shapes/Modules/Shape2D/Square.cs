using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Square : ISquare
    {
        public double Perimeter { get; }
        public double Area { get; }
        public double Side { get; }

        public Square(double side, double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
            Side = side;
        }
        public override string ToString() =>
            $"Квадрат со стороной = {Side}, площадью = {Area} и периметром = {Perimeter}";
    }
}
