using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure2D
{
    public class Square : Shape2D
    {
        private Rectangle _rectangle;

        /// <exception cref="ArgumentException">
        /// Сторона не может быть меньше или равно нулю.
        /// </exception>
        public double Side
        {
            get => _rectangle.Width;
            set
            {
                Validate(value);
                _rectangle.Width = value;
                _rectangle.Height = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        /// <exception cref="ArgumentException">
        /// Сторона не может быть меньше или равно нулю.
        /// </exception>
        public Square(double side, Point2D center) : base(center)
        {
            Validate(side);
            _rectangle = new Rectangle(side, side, center);
            Side = side;
        }
        public Square(double side, double x, double y) : this(side, new Point2D(x, y)) { }

        public static implicit operator Rectangle(Square s) => new Rectangle(s.Side, s.Side, s.Center);

        protected override void CalculateArea() => Area = _rectangle.Area;
        protected override void CalculatePerimeter() => Perimeter = _rectangle.Perimeter;

        private void Validate(double side)
        {
            if (side <= 0)
                throw new ArgumentException($"Отрицательная или нулевая сторона: {side}.");           
        }
    }
}
