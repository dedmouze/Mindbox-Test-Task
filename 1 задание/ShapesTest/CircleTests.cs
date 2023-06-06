using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Get_CircleAreaWithRadius10_Returns314()
        {
            int radius = 10;
            double expected = radius * radius * Math.PI;
            Circle c = new Circle(radius);
            Assert.AreEqual(expected, c.Area);
        }
        [TestMethod]
        public void Get_CirclePerimeterWithRadius10_Returns314()
        {
            int radius = 10;
            double expected = 2 * radius * Math.PI;
            Circle c = new Circle(radius);
            Assert.AreEqual(expected, c.Perimeter);
        }
        [TestMethod]
        public void Create_CircleWithNegativeRadius_ThrowsArgumentException()
        {
            int radius = -1;
            Action actual = () => new Circle(radius);
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}