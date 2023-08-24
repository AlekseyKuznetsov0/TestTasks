using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestClass]
    public class Triangle_ConstructAnObject
    {
        [TestMethod]
        public void SidesLengthCorrect()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle t = new Triangle(sideA, sideB, sideC);
            Assert.AreNotEqual(null, t);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SidesLengthNotCorrect()
        {
            double sideA = 1465.6597545648;
            double sideB = 397.65489424654;
            double sideC = 543.54568798132;
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideA_LengthNegative()
        {
            Random r = new Random();
            double sideA = -1 * (r.NextDouble() * r.Next(1, 100) + 1E-5);
            double sideB = r.NextDouble() * r.Next(1, 100);
            double sideC = r.NextDouble() * r.Next(1, 100);
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideB_LengthNegative()
        {
            Random r = new Random();
            double sideA = r.NextDouble() * r.Next(1, 100);
            double sideB = -1 * (r.NextDouble() * r.Next(1, 100) + 1E-5);
            double sideC = r.NextDouble() * r.Next(1, 100);
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideC_LengthNegative()
        {
            Random r = new Random();
            double sideA = r.NextDouble() * r.Next(1, 100);
            double sideB = r.NextDouble() * r.Next(1, 100);
            double sideC = -1 * (r.NextDouble() * r.Next(1, 100) + 1E-5);
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideA_LengthEqualZero()
        {
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideB_LengthEqualZero()
        {
            double sideA = 3;
            double sideB = 0;
            double sideC = 5;
            Triangle t = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SideC_LengthEqualZero()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 0;
            Triangle t = new Triangle(sideA, sideB, sideC);
        }
    }
}