using Shapes.Interfaces.Shape2D;
using Shapes.Interfaces.Shape3D;
using Shapes.ShapeFactories.TemplateMethod;

namespace Shapes
{
    public class ShapeFactory
    {
        public ISphere CreateSphere(double radius) => (new SphereCreator(radius)).Create();
        public ICube CreateCube(double side) => (new CubeCreator(side)).Create();
        public ICircle CreateCircle(double radius) => (new CircleCreator(radius)).Create();
        public IRectangle CreateRectangle(double width, double height) => (new RectangleCreator(width, height)).Create();
        public ISquare CreateSquare(double side) => (new SquareCreator(side)).Create();
        public ITriangle CreateTriangle(double sideA, double sideB, double sideC) => (new TriangleCreator(sideA, sideB, sideC)).Create();
    }
}