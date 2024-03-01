using Shapes.Interfaces.Shape3D;
using Shapes.Modules.Figure3D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class CubeCreator : ShapeCreator<ICube>
    {
        private double _side;

        public CubeCreator(double side) => _side = side;

        protected override ICube GetShape() => new Cube(_side, _side * _side * _side);

        protected override void PossibilityValues()
        {
            if (_side <= 0)
                throw new ArgumentException($"Куб со стороной = {_side} невозможно создать");
        }
    }
}