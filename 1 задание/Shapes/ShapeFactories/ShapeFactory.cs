using Shapes.Interfaces;
using Shapes.Interfaces.Shape2D;
using Shapes.Interfaces.Shape3D;
using Shapes.ShapeFactories.TemplateMethod;

namespace Shapes
{
    public class ShapeFactory
    {
        public ISphere CreateSphere(double radius) => Create(new SphereCreator(radius));
        public ICube CreateCube(double side) => Create(new CubeCreator(side));
        public ICircle CreateCircle(double radius) => Create(new CircleCreator(radius));
        public IRectangle CreateRectangle(double width, double height) => Create(new RectangleCreator(width, height));
        public ISquare CreateSquare(double side) => Create(new SquareCreator(side));
        public ITriangle CreateTriangle(double sideA, double sideB, double sideC) => Create(new TriangleCreator(sideA, sideB, sideC));
        private T Create<T>(ShapeCreator<T> shapeCreator) where T : IShape => shapeCreator.Create();
    }
}