using Shapes.Interfaces;

namespace Shapes.ShapeFactories.TemplateMethod
{
    internal abstract class ShapeCreator<T> where T : IShape
    {
        public T Create()
        {
            PossibilityValues();
            PossibilityCreateShape();
            return GetShape();
        }
        protected virtual void PossibilityCreateShape() { }
        protected abstract void PossibilityValues();
        protected abstract T GetShape();
    }
}