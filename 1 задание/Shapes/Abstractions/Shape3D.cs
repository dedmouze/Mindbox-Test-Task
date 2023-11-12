using Shapes.Interfaces.Shape3D;

namespace Shapes.Abstractions
{
    internal abstract class Shape3D : IShape3D
    {
        public double Volume { get; }
        public Shape3D(double volume) => Volume = volume;
        public abstract override string ToString();
    }
}
