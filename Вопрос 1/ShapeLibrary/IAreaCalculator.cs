using ShapeLibrary.Shapes;

namespace ShapeLibrary
{
    public interface IAreaCalculator
    {
        double GetShapeArea(Shape shape);
        double GetCircleArea(double radius);
        double GetTriangleArea(double lengthSideA, double lengthSideB, double lengthSideC);
    }
}
