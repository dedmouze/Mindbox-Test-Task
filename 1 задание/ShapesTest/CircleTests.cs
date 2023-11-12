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
        [TestMethod]
        public void Create_CircleWithNegativeRadius_ThrowsArgumentException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            int radius = -1;
            Action actual = () => shapeFactory.CreateCircle(radius);
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}