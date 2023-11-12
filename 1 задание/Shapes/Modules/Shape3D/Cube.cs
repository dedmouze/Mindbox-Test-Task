using Shapes.Abstractions;
using Shapes.Interfaces.Shape3D;

namespace Shapes.Modules.Figure3D
{
    internal sealed class Cube : Shape3D, ICube
    {
        public double Side { get; }
        public Cube(double side, double volume) : base(volume) => Side = side;
        public override string ToString() =>
            $"Куб со стороной = {Side} и объёмом = {Volume}";
    }
}
