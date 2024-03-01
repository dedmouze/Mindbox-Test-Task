using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape2D;
using Shapes;
using System.Collections.Immutable;

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
        public void Get_TrianglePerimeterWithSides5_12_13_Return30()
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
        public void Is_TriangleWithSides5_10_13Right_ReturnFalse()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double a = 5, b = 10, c = 13;
            bool expected = false;

            ITriangle triangle = shapeFactory.CreateTriangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsRight);
        }

        [DataTestMethod]
        [DataRow(-1, 5, 13)]
        [DataRow(9, -1, 13)]
        [DataRow(9, 5, -1)]
        [DataRow(0, 5, 13)]
        [DataRow(9, 0, 13)]
        [DataRow(9, 5, 0)]
        public void Create_TriangleWithWrongSide_ThrowsArgumentException(double a, double b, double c)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateTriangle(a, b, c)).Message,
                $"Невозможно создать треугольник с такими сторонами {a}, {b}, {c}"
                );
        }

        [DataTestMethod]
        [DataRow(5, 5, 10)]
        [DataRow(5, 10, 5)]
        [DataRow(10, 5, 5)]
        [DataRow(10, 5, 4)]
        [DataRow(4, 10, 5)]
        [DataRow(4, 5, 10)]
        public void Create_TriangleWithImpossibleSides_ThrowsArgumentException(double a, double b, double c)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            double[] sides = { a, b, c };
            Array.Sort(sides);
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateTriangle(a, b, c)).Message,
                $"Такого треугольника не сущетсвует так как {sides[0]} + {sides[1]} <= {sides[2]}"
                );
        }
    }
}
