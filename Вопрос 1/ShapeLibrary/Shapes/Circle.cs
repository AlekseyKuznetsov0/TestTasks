namespace ShapeLibrary.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2),10);

        public Circle(double radius) : base("Окружность")
        {
            if (radius < 1E-5)
                throw new ArgumentOutOfRangeException("Radius", radius, "Радиус окружности меньше 1E-5");
            Radius = radius;
        }
    }
}
