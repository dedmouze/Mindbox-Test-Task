using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape3D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void Get_CubeVolumeWithSides5_Returns125()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double side = 5;
            double expected = 125;

            ICube cube = shapeFactory.CreateCube(side);
            Assert.AreEqual(expected, cube.Volume);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Create_CubeWithWrongSides_ThrowsArgumentException(double side)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateCube(side)).Message,
                $"Куб со стороной = {side} невозможно создать"
                );
        }
    }
}