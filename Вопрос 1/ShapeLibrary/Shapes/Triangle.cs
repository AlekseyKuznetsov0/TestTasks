namespace ShapeLibrary.Shapes
{
    public class Triangle : Shape
    {
        public double LengthSideA { get; }
        public double LengthSideB { get; }
        public double LengthSideC { get; }

        public bool IsRightAngled
        {
            get
            {
                double eps = 1E-15;
                List<double> sides = new List<double>() { LengthSideA, LengthSideB, LengthSideC };
                sides.Sort();
                return Math.Round(Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)), 15) <= eps ? true : false;
            }
        }
        public override double Area
        {
            get
            {
                double p = (LengthSideA + LengthSideB + LengthSideC) / 2;
                return Math.Round(Math.Sqrt(p * (p - LengthSideA) * (p - LengthSideB) * (p - LengthSideC)), 15);
            }
        }

        public Triangle(double lengthSideA, double lengthSideB, double lengthSideC) : base("Треугольник")
        {
            if (lengthSideA < 1E-5)
                throw new ArgumentOutOfRangeException("lengthSideA", lengthSideA, "Длина меньше 1E-5");
            if (lengthSideB < 1E-5)
                throw new ArgumentOutOfRangeException("lengthSideB", lengthSideB, "Длина меньше 1E-5");
            if (lengthSideC < 1E-5)
                throw new ArgumentOutOfRangeException("lengthSideC", lengthSideC, "Длина меньше 1E-5");


            if (lengthSideA + lengthSideB <= lengthSideC ||
                lengthSideA + lengthSideC <= lengthSideB ||
                lengthSideB + lengthSideC <= lengthSideA)
                throw new ArgumentException(
                    "Треугольника с такими сторонами не уществует. Сумма длин любых двух сторон треугольника должна быть больше длины третьей стороны");

            LengthSideA = lengthSideA;
            LengthSideB = lengthSideB;
            LengthSideC = lengthSideC;
        }
    }
}
