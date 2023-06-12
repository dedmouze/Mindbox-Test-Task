using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure3D
{
    public class Cube : Shape3D
    {
        /// <exception cref="ArgumentException">
        /// Сторона не может быть меньше или равно нулю.
        /// </exception>
        public double Side
        {
            get => Side;
            set
            {
                Validate(value);
                Side = value;
                CalculateArea();
                CalculateVolume();
            }
        }

        /// <exception cref="ArgumentException">
        /// Сторона не может быть меньше или равно нулю.
        /// </exception>
        public Cube(double side, Point3D center) : base(center) => Side = side;
        public Cube(double side, double x, double y, double z) : this(side, new Point3D(x, y, z)) { }

        protected override void CalculateArea() => Area = 6 * Side * Side;
        protected override void CalculateVolume() => Volume = Side * Side * Side;

        private void Validate(double side)
        {
            if (side <= 0)
                throw new ArgumentException($"Отрицательная или нулевая сторона: {side}.");
        }
    }
}
