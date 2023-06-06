using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            A = sides[0]; B = sides[1]; C = sides[2];
            ValidateInput();
            CalculateArea();
            CalculatePerimeter();
        }

        public bool IsTriangleRight(double eps = 10E-6)
            => Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) <= eps;

        protected override void CalculateArea()
        {
            double halfPerimeter = (A + B + C) / 2;
            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }
        protected override void CalculatePerimeter() => Perimeter = A + B + C;
        protected override void ValidateInput()
        {
            if (A <= 0 || B <= 0 || C <= 0)
                throw new ArgumentException($"Стороны треугольника должны быть положительными.");
            if (A >= B + C || B >= A + C || C >= A + B)
                throw new ArgumentException($"Из представленных сторон невозможно сформировать треугольник.");

        }
    }
}
