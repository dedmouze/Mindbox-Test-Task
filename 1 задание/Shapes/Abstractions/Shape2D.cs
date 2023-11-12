using Shapes.Interfaces.Shape2D;

namespace Shapes.Abstractions
{
    internal abstract class Shape2D : IShape2D
    {
        public double Perimeter { get; }
        public double Area { get; }
        public Shape2D(double area, double perimeter)
        {
            Perimeter = perimeter;
            Area = area;
        }
        public abstract override string ToString();
    }
}
