using Shapes.Interfaces.Shape2D;
using Shapes.Modules.Figure2D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class SquareCreator : ShapeCreator<ISquare>
    {
        private double _side;

        public SquareCreator(double side) => _side = side;

        protected override ISquare GetShape() => new Square(_side, _side * _side, 4 * _side);

        protected override void PossibilityValues()
        {
            if (_side <= 0)
                throw new ArgumentException($"Квадрат со стороной = {_side} невозможно создать");
        }
    }
}