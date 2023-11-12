namespace Shapes.Interfaces.Shape2D
{
    public interface IShape2D : IShape
    {
        double Perimeter { get; }
        double Area { get; }
    }
}