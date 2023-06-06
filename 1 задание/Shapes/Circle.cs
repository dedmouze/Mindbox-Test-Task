using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            Radius = radius;
            ValidateInput();
            CalculateArea();
            CalculatePerimeter();
        }

        protected override void CalculateArea() => Area = Radius * Radius * Math.PI;
        protected override void CalculatePerimeter() => Perimeter = 2 * Radius * Math.PI;
 
        protected override void ValidateInput()
        {
            if (Radius < 0) 
                throw new ArgumentException($"Отрицательный радиус: {Radius}.");
        }
    }
}
