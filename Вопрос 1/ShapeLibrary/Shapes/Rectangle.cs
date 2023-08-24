namespace ShapeLibrary.Shapes
{
    public class Rectangle : Shape
    {
        public double Height { get; }
        public double Width { get; }

        public override double Area => Math.Round(Height * Width, 10);

        public Rectangle(double height, double width) : base("Прямоугольник")
        {
            if (height < 1E-5)
                throw new ArgumentOutOfRangeException("height", height, "Длина меньше 1E-5");
            if (width < 1E-5)
                throw new ArgumentOutOfRangeException("width", width, "Ширина меньше 1E-5");

            Height = height;
            Width = width;
        }
    }
}
