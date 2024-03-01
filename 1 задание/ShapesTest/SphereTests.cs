using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Interfaces.Shape3D;
using Shapes;

namespace ShapeTests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Get_SphereVolumeWithRadius10_Returns4188()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            double radius = 10;
            double expected = (4 / 3) * Math.Pow(radius, 3) * Math.PI;

            ISphere circle = shapeFactory.CreateSphere(radius);
            Assert.AreEqual(expected, circle.Volume);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Create_SphereWithWrongRadius_ThrowsArgumentException(double radius)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Assert.AreEqual(
                Assert.ThrowsException<ArgumentException>(() => shapeFactory.CreateSphere(radius)).Message,
                $"Сферу с отрицательным и нулевым радиусом невомзожно создать = {radius}"
                );
        }
    }
}