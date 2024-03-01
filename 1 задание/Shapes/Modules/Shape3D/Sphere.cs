using Shapes.Interfaces.Shape3D;

namespace Shapes.Modules.Figure3D
{
    internal sealed class Sphere : ISphere
    {
        public double Volume { get; }
        public double Radius { get; }

        public Sphere(double radius, double volume)
        {
            Volume = volume;
            Radius = radius;
        }
        public override string ToString()
            => $"Сфера с радиусом = {Radius} и объёмом = {Volume}";
    }
}
