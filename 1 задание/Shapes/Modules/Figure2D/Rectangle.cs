using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure2D
{
    public class Rectangle : Shape2D
    {
        private double _height;
        private double _width;

        /// <exception cref="ArgumentException">
        /// Высота не может быть меньше или равна нулю.
        /// </exception>
        public double Height
        {
            get => _height;
            set
            {
                Validate(value, _width);
                _height = value;
            }
        }
        /// <exception cref="ArgumentException">
        /// Ширина не может быть меньше или равна нулю.
        /// </exception>
        public double Width
        {
            get => _width;
            set
            {
                Validate(_height, value);
                _width = value;
            }
        }

        /// <exception cref="ArgumentException">
        /// Сторны не могут быть меньше или равными нулю.
        /// </exception>
        public Rectangle(double height, double width, Point2D center) : base(center)
        {
            Validate(height, width);
            _height = height;
            _width = width;
            CalculateArea();
            CalculatePerimeter();
        }
        public Rectangle(double height, double width, double x, double y) : this(height, width, new Point2D(x, y)) { }

        protected override void CalculateArea() => Area = _width * _height;
        protected override void CalculatePerimeter() => Perimeter = 2 * (_width + _height);

        private void Validate(double height, double width)
        {
            if (height <= 0)
                throw new ArgumentException($"Отрицательная или нулевая высота: {height}.");

            if (width <= 0)
                throw new ArgumentException($"Отрицательная или нулевая ширина: {width}.");
        }
    }
}
