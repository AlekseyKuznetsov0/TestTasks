using ShapeLibrary.Shapes;

namespace ShapeLibrary
{
    public class AreaCalculator : IAreaCalculator
    {
        public double GetShapeArea(Shape shape) => shape.Area;
        public double GetCircleArea(double radius) => new Circle(radius).Area;
        public double GetTriangleArea(double lengthSideA, double lengthSideB, double lengthSideC) => new Triangle(lengthSideA, lengthSideB, lengthSideC).Area;
    }
}
