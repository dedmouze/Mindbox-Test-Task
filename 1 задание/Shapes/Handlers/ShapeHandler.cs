using Shapes.Interfaces;

namespace Shapes.Handlers
{
    public class ShapeHandler
    {
        public double GetArea(IShape shape) => shape.Area;
        public double GetPerimeter(IShape2D shape) => shape.Perimeter;
        public double GetVolume(IShape3D shape) => shape.Volume;
    }
}
