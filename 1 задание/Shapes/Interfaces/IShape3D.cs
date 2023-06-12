using Shapes.Structures;

namespace Shapes.Interfaces
{
    public interface IShape3D : IShape
    {
        public double Volume { get; }
        public Point3D Center { get; }
    }
}
