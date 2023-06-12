using Shapes.Interfaces;
using Shapes.Structures;

namespace Shapes.Abstractions
{
    public abstract class Shape3D : Shape, IShape3D
    {
        public double Volume { get; protected set; }
        public Point3D Center { get; protected set; }

        public override string ToString()
            => $"Фигура: {GetType().Name}, Площадь: {Area}, Объем: {Volume}";

        protected Shape3D(Point3D center) => Center = center;

        protected abstract void CalculateVolume();
    }
}
