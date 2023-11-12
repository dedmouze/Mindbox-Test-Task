using Shapes.Interfaces.Shape2D;
using Shapes.Modules.Figure2D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class RectangleCreator : ShapeCreator<IRectangle>
    {
        private double _width;
        private double _height;

        public RectangleCreator(double width, double height)
        {
            _width = width;
            _height = height;
        }

        protected override IRectangle GetShape() => new Rectangle(_width, _height, _width * _height, 2 * (_width + _height));

        protected override void PossibilityValues()
        {
            if (_width <= 0)
                throw new ArgumentException($"Создать прямоугольник с отрицательной стороной {_width} невозможно");
            else if (_height <= 0)
                throw new ArgumentException($"Создать прямоугольник с отрицательной стороной {_height} невозможно");
        }
    }
}