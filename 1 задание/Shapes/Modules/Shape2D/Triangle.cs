using Shapes.Interfaces.Shape2D;

namespace Shapes.Modules.Figure2D
{
    internal sealed class Triangle : ITriangle
    {
        public double Perimeter { get; }
        public double Area { get; }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRight { get; }

        public Triangle(double sideA, double sideB, double sideC, bool isRight, double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRight = isRight;
        }
        public override string ToString()
        {
            string triangleType = IsRight ? "Прямоугольный треугольник" : "Треугольник";
            return $"{triangleType} со сторонами = {SideA}, {SideB}, {SideC}, а также с площадью = {Area} и периметром = {Perimeter}";
        }
    }
}
