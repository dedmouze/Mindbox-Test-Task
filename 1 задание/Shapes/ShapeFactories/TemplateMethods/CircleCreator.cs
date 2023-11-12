using Shapes.Interfaces.Shape2D;
using Shapes.Modules.Figure2D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class CircleCreator : ShapeCreator<ICircle>
    {
        private const double PI = Math.PI;

        private double _radius;
        public CircleCreator(double radius) => _radius = radius;

        protected override ICircle GetShape() => new Circle(_radius, PI* _radius * _radius, 2 * PI* _radius);

        protected override void PossibilityValues()
        {
            if (_radius <= 0)
                throw new ArgumentException($"Отрицательный радиус невозможен для создания круга: {_radius}");
        }
    }
}