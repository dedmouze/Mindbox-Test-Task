using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Get_TriangleAreaWithSides3_4_5_Returns6()
        {
            int a = 3, b = 4, c = 5;
            int expected = 6;
            Triangle t = new Triangle(a, b, c);
            Assert.AreEqual(expected, t.Area);
        }
        [TestMethod]
        public void Get_TrianglePerimeterWithSides3_4_5_Returns12()
        {
            int a = 3, b = 4, c = 5;
            int expected = 12;
            Triangle t = new Triangle(a, b, c);
            Assert.AreEqual(expected, t.Perimeter);
        }
        [TestMethod]
        public void Is_TriangleWithSides3_4_5Right_ReturnsTrue()
        {
            int a = 3, b = 4, c = 5;
            bool expected = true;
            Triangle t = new Triangle(a, b, c);
            Assert.AreEqual(expected, t.IsTriangleRight());
        }

        [TestMethod]
        public void Is_TriangleWithSides3_4_6Right_ReturnsFalse()
        {
            int a = 3, b = 4, c = 6;
            bool expected = false;
            Triangle t = new Triangle(a, b, c);
            Assert.AreEqual(expected, t.IsTriangleRight());
        }
        [TestMethod]
        public void Create_TriangleWithZeroSide_ThrowsArgumentException()
        {
            int a = 0, b = 3, c = 4;
            Action actual = () => new Triangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(actual);
        }
        [TestMethod]
        public void Create_TriangleWithNegativeSide_ThrowsArgumentException()
        {
            int a = -1, b = 3, c = 4;
            Action actual = () => new Triangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(actual);
        }
        [TestMethod]
        public void Create_TriangleWithWrongSizeSides_ThrowsArgumentException()
        {
            int a = 2, b = 3, c = 5;
            Action actual = () => new Triangle(a, b, c);
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}
