namespace Shapes.Interfaces.Shape2D
{
    public interface ITriangle : IShape2D
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRight { get; }
    }
}
