using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape2D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Get_RectangleAreaWithSides35_Returns15()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double width = 3;
            double height = 5;
            double expected = 15;

            IRectangle rectangle = shapeFactory.CreateRectangle(width, height);
            Assert.AreEqual(expected, rectangle.Area);
        }
        public void Get_RectanglePerimeterWithSides35_Returns16()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double width = 3;
            double height = 5;
            double expected = 16;

            IRectangle rectangle = shapeFactory.CreateRectangle(width, height);
            Assert.AreEqual(expected, rectangle.Perimeter);
        }

        [DataTestMethod]
        [DataRow(-1, 5)]
        [DataRow(5, -1)]
        [DataRow(0, 5)]
        [DataRow(5, 0)]
        public void Create_RectangleWithWrongSides_ThrowsArgumentException(double width, double height)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Action actual = () => shapeFactory.CreateRectangle(width, height);
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}