using Shapes.Interfaces;

namespace Shapes.Abstractions
{
    public abstract class Shape : IShape
    {
        public double Area { get; protected set; }

        protected abstract void CalculateArea();
    }
}
