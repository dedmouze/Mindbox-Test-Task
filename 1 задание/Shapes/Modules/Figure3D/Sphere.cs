using System;
using Shapes.Abstractions;
using Shapes.Structures;

namespace Shapes.Modules.Figure3D
{
    public class Sphere : Shape3D
    {
        /// <exception cref="ArgumentException">
        /// Радиус не может быть отрицательным.
        /// </exception>
        public double Radius
        {
            get => Radius;
            set
            {
                Validate(Radius);
                Radius = value;
            }
        }

        /// <exception cref="ArgumentException">
        /// Радиус не может быть отрицательным.
        /// </exception>
        public Sphere(double radius, Point3D center) : base(center) => Radius = radius;
        public Sphere(double radius, double x, double y, double z) : this(radius, new Point3D(x, y, z)) { }

        protected override void CalculateArea() => Area = 4 * Math.PI * Radius * Radius;
        protected override void CalculateVolume() => Volume = 4 / 3 * Math.PI * Radius * Radius * Radius;

        private void Validate(double radius)
        {
            if (radius < 0)
                throw new ArgumentException($"Отрицательный радиус: {radius}");
        }
    }
}
