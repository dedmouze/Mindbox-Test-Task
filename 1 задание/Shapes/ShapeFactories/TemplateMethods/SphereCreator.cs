using Shapes.Interfaces.Shape3D;
using Shapes.Modules.Figure3D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class SphereCreator : ShapeCreator<ISphere>
    {
        private const double PI = Math.PI;

        private double _radius;

        public SphereCreator(double radius) => _radius = radius;

        protected override ISphere GetShape() => new Sphere(_radius, (4 / 3) * Math.Pow(_radius, 3) * PI);

        protected override void PossibilityValues()
        {
            if (_radius <= 0)
                throw new ArgumentException($"Сферу с отрицательным и нулевым радиусом невомзожно создать = {_radius}");
        }
    }
}