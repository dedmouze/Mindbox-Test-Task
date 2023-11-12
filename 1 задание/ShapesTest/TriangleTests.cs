using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape2D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Get_TriangleAreaWithSides5_12_13_Return30()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 12, c = 13;
            double expectedArea = 30;

            ITriangle triangle = shapeFactory.CreateTriangle(a, b, c);
            Assert.AreEqual(expectedArea, triangle.Area);
        }

        [TestMethod]
        public void Get_TrianglePerimeterWithSides5_12_13_Return_30()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 12, c = 13;
            double expectedArea = 30;

            ITriangle triangle = shapeFactory.CreateTriangle(a, b, c);
            Assert.AreEqual(expectedArea, triangle.Perimeter);
        }

        [TestMethod]
        public void Is_TriangleWithSides5_12_13Right_ReturnTrue()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 12, c = 13;
            bool expected = true;

            ITriangle triangle = shapeFactory.CreateTriangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsRight);
        }

        [TestMethod]
        public void Is_TriangleWithSides5_10_13Right_ReturnTFalse()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 10, c = 13;
            bool expected = false;

            ITriangle triangle = shapeFactory.CreateTriangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsRight);
        }

        [TestMethod]
        public void Create_TriangleWithNegativeSide_ThrowsArgumentException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = -1, c = 13;
            Action create = () => shapeFactory.CreateTriangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void Create_TriangleWithZeroSide_ThrowsArgumentException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 0, c = 13;
            Action create = () => shapeFactory.CreateTriangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(create);
        }

        [TestMethod]
        public void Create_TriangleWithWrongSides_ThrowsArgumentException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 5, c = 10;
            Action create = () => shapeFactory.CreateTriangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(create);
        }
    }
}
