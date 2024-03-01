using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape2D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Get_SquareAreaWithSides5_Returns25()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double side = 5;
            double expected = 25;

            ISquare square = shapeFactory.CreateSquare(side);
            Assert.AreEqual(expected, square.Area);
        }

        [TestMethod]
        public void Get_SquarePerimeterWithSides5_Returns20()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double side = 5;
            double expected = 20;

            ISquare square = shapeFactory.CreateSquare(side);
            Assert.AreEqual(expected, square.Perimeter);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Create_RectangleWithNegativeWidth_ThrowsArgumentException(double side)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateSquare(side)).Message,
                $"Квадрат со стороной = {side} невозможно создать"
                );
        }
    }
}