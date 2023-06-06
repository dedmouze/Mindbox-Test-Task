namespace Shapes
{
    public abstract class Shape : IShape
    {
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }

        public override string ToString()
            => $"Фигура: {GetType().Name}, Периметр: {Perimeter}, Площадь: {Area}.";

        protected abstract void CalculateArea();
        protected abstract void CalculatePerimeter();

        /// <exception cref="ArgumentException"></exception>
        protected abstract void ValidateInput();
    }
}
