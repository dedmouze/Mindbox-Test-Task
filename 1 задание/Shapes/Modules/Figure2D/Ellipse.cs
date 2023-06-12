using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure2D
{
    public class Ellipse : Shape2D
    {
        private double _majorAxis;
        private double _minorAxis;

        /// <exception cref="ArgumentException">
        /// Ось не может быть меньше или равной нулю. 
        /// Большая ось не может быть больше малой.
        /// </exception>
        public double MajorAxis
        {
            get => _majorAxis;
            set
            {
                Validate(value, _majorAxis);
                _majorAxis = value;
                CalculateProperties();
            }
        }
        /// <exception cref="ArgumentException">
        /// Ось не может быть меньше или равной нулю. 
        /// Большая ось не может быть больше малой.
        /// </exception>
        public double MinorAxis
        {
            get => _minorAxis;
            set
            {
                Validate(_minorAxis, value);
                _minorAxis = value;
                CalculateProperties();
            }
        }

        public Point2D FocalA { get; private set; }
        public Point2D FocalB { get; private set; }

        public double Eccentricity { get; private set; }


        /// <exception cref="ArgumentException">
        /// Ось не может быть меньше или равной нулю. 
        /// Большая ось не может быть больше малой.
        /// </exception>
        public Ellipse(double majorAxis, double minorAxis, Point2D center) : base(center)
        {
            Validate(majorAxis, minorAxis);
            _majorAxis = majorAxis;
            _minorAxis = minorAxis;
            CalculateProperties();
        }
        public Ellipse(double majoirAxis, double minorAxis, double x, double y) : 
            this(majoirAxis, minorAxis, new Point2D(x, y)) { }

        protected override void CalculateArea() => Area = Math.PI * _majorAxis * _minorAxis;
        protected override void CalculatePerimeter()
        {
            double temp = 3 * Math.Pow((_majorAxis - _minorAxis) / (_majorAxis + _minorAxis), 2);
            Perimeter = Math.PI * (_majorAxis + _minorAxis) * (1 + temp) / 10 + Math.Sqrt(4 - temp);
        }
        protected void CalculateFocals()
        {
            double c = Math.Sqrt(Math.Pow(_majorAxis, 2) - Math.Pow(_minorAxis, 2));
            FocalA = new Point2D(c, Center.Y);
            FocalB = new Point2D(-c, Center.Y);
        }
        protected void CalculateEccentricity()
        {
            double c = Math.Sqrt(Math.Pow(_majorAxis, 2) - Math.Pow(_minorAxis, 2));
            Eccentricity = c / _majorAxis;
        }
        protected void CalculateProperties()
        {
            CalculateArea();
            CalculatePerimeter();
            CalculateFocals();
            CalculateEccentricity();
        }

        private void Validate(double majorAxis, double minorAxis)
        {
            if (majorAxis <= 0)
                throw new ArgumentException($"Отрицательная или нулевая ось: {majorAxis}");
            if (minorAxis <= 0)
                throw new ArgumentException($"Отрицательная или нулевая ось: {minorAxis}");

            if (majorAxis < minorAxis)
                throw new ArgumentException($"Большая ось меньше малой: {majorAxis} < {minorAxis}");
        }
    }
}
