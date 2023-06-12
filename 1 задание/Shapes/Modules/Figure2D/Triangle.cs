using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure2D
{
    public class Triangle : Shape2D
    {
        private double _sideA;
        private double _sideB; 
        private double _sideC;

        /// <exception cref="ArgumentException">
        /// Длина стороны не может быть отрицательным.
        /// Сумма любых двух сторон должна быть больше третьей.
        /// </exception>
        public double SideA
        {
            get => _sideA;
            set
            {
                Validate(value, _sideB, _sideC);
                _sideA = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }
        /// <exception cref="ArgumentException">
        /// Длина стороны не может быть отрицательным.
        /// Сумма любых двух сторон должна быть больше третьей.
        /// </exception>
        public double SideB
        {
            get => _sideB;
            set
            {
                Validate(_sideA, value, _sideC);
                _sideB = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }
        /// <exception cref="ArgumentException">
        /// Длина стороны не может быть отрицательным.
        /// Сумма любых двух сторон должна быть больше третьей.
        /// </exception>
        public double SideC
        {
            get => _sideC;
            set
            {
                Validate(_sideA, _sideB, value);
                _sideC = value;
                CalculateArea();
                CalculatePerimeter();
            }
        }

        /// <exception cref="ArgumentException">
        /// Длины сторон не могут быть отрицательными.
        /// Сумма любых двух сторон должна быть больше третьей.
        /// </exception>
        public Triangle(double sideA, double sideB, double sideC, Point2D center) : base(center)
        {
            Validate(sideA, sideB, sideC);
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            _sideA = sides[0]; _sideB = sides[1]; _sideC = sides[2];
            CalculateArea();
            CalculatePerimeter();
        }
        public Triangle(double sideA, double sideB, double sideC, double x, double y) : 
            this(sideA, sideB, sideC, new Point2D(x, y)) { }

        public bool IsTriangleRight(double eps = 10E-6)
            => Math.Abs(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) - Math.Pow(_sideC, 2)) <= eps;

        protected override void CalculateArea()
        {
            double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
        }
        protected override void CalculatePerimeter() => Perimeter = _sideA + _sideB + _sideC;

        private void Validate(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException($"Отрицательная длина: {a}, {b}, {c}.");

            if (a >= b + c || b >= a + c || c >= a + b)
                throw new ArgumentException($"Невозможный треугольник: {a}, {b}, {c}");
        }
    }
}