using Shapes.Interfaces.Shape2D;
using Shapes.Modules.Figure2D;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal sealed class TriangleCreator : ShapeCreator<ITriangle>
    {
        private const double EPS = 10E-6;

        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double[] _sortedSides;

        public TriangleCreator(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            _sortedSides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(_sortedSides);
        }

        protected override ITriangle GetShape()
        {
            double perimeter = _sortedSides[0] + _sortedSides[1] + _sortedSides[2];
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sortedSides[0]) * (halfPerimeter - _sortedSides[1]) * (halfPerimeter - _sortedSides[2]));
            bool isRight = Math.Abs(Math.Pow(_sortedSides[0], 2) + Math.Pow(_sortedSides[1], 2) - Math.Pow(_sortedSides[2], 2)) <= EPS;
            return new Triangle(_sideA, _sideB, _sideC, isRight, area, perimeter);
        }

        protected override void PossibilityCreateShape()
        {
            if (_sortedSides[0] + _sortedSides[1] <= _sortedSides[2])
                throw new ArgumentException($"Такого треугольника не сущетсвует так как {_sortedSides[0]} + {_sortedSides[1]} <= {_sortedSides[2]}");
        }

        protected override void PossibilityValues()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
                throw new ArgumentException($"Невозможно создать треугольник с такими сторонами {_sideA}, {_sideB}, {_sideC}");
        }
    }
}