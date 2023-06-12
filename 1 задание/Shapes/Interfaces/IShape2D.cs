using Shapes.Structures;

namespace Shapes.Interfaces
{
    public interface IShape2D : IShape
    {
        double Perimeter { get; }
        public Point2D Center { get; }
    }
}
