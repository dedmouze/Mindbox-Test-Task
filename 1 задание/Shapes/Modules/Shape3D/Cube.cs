using Shapes.Interfaces.Shape3D;

namespace Shapes.Modules.Figure3D
{
    internal sealed class Cube : ICube
    {
        public double Volume { get; }
        public double Side { get; }

        public Cube(double side, double volume)
        {
            Volume = volume;
            Side = side;
        }
        public override string ToString() =>
            $"Куб со стороной = {Side} и объёмом = {Volume}";
    }
}
