using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestClass]
    public class Circle_ConstructAnObject
    {
        [TestMethod]
        public void RadiusLengthPositive()
        {
            Random r = new Random();
            double radius = r.NextDouble() * r.Next(1, 100) + 1E-5;
            Circle c = new Circle(radius);
            Assert.AreNotEqual(null, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RadiusLengthNegative()
        {
            Random r = new Random();
            double radius = -1 * (r.NextDouble() * r.Next(1, 100) + 1E-5);
            Circle c = new Circle(radius);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RadiusLengthEqualZero()
        {
            Circle c = new Circle(0);
        }
    }
}