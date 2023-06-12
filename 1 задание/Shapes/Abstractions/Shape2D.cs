using Shapes.Interfaces;
using Shapes.Structures;

namespace Shapes.Abstractions
{
    public abstract class Shape2D : Shape, IShape2D
    {
        public Point2D Center { get; protected set; }
        public double Perimeter { get; protected set; }

        protected Shape2D(Point2D center) => Center = center;

        public override string ToString()
            => $"Фигура: {GetType().Name}, Периметр: {Perimeter}, Площадь: {Area}.";

        protected abstract void CalculatePerimeter();
    }
}
