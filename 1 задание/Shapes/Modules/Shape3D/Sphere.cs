using Shapes.Abstractions;
using Shapes.Interfaces.Shape3D;

namespace Shapes.Modules.Figure3D
{
    internal sealed class Sphere : Shape3D, ISphere
    {
        public double Radius { get; }
        public Sphere(double radius, double volume) : base(volume) => Radius = radius;
        public override string ToString()
            => $"Сфера с радиусом = {Radius} и объёмом = {Volume}";
    }
}
