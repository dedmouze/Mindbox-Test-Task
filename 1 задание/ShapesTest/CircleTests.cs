using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape2D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Get_CircleAreaWithRadius10_Returns314()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double radius = 10;
            double expected = radius * radius * Math.PI;

            ICircle circle = shapeFactory.CreateCircle(radius);
            Assert.AreEqual(expected, circle.Area);
        }
        public void Get_CirclePerimeterWithRadius10_Returns314()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double radius = 10;
            double expected = 2 * radius * Math.PI;

            ICircle circle = shapeFactory.CreateCircle(radius);
            Assert.AreEqual(expected, circle.Perimeter);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Create_CircleWithWrongRadius_ThrowsArgumentException(double radius)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateCircle(radius)).Message,
                $"Отрицательный радиус невозможен для создания круга: {radius}"
                );
        }
    }
}