using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure2D
{
    public class Circle : Shape2D
    {
        /// <exception cref="ArgumentException">
        /// Радиус не может быть отрицательным.
        /// </exception>
        public double Radius 
        {
            get => Radius;
            set
            {
                Validate(value);
                Radius = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        /// <exception cref="ArgumentException">
        /// Радиус не может быть отрицательным.
        /// </exception>
        public Circle(double radius, Point2D center) : base(center) => Radius = radius;
        public Circle(double radius, double x, double y) : this(radius, new Point2D(x, y)) { }

        public static implicit operator Ellipse(Circle c) => new Ellipse(c.Radius, c.Radius, c.Center);

        protected override void CalculateArea() => Area = Radius * Radius * Math.PI;
        protected override void CalculatePerimeter() => Perimeter = 2 * Radius * Math.PI;

        private void Validate(double radius)
        {
            if (radius < 0) 
                throw new ArgumentException($"Отрицательный радиус: {radius}");
        }
    }
}
