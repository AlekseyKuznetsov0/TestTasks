using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestClass]
    public class Circle_CanGetArea
    {
        [TestMethod]
        public void Radius5_Area78_5398163397()
        {
            double delta = 1E-10;
            Circle c = new Circle(5);
            double expected = 78.5398163397;
            double actual = c.Area;
            Assert.AreEqual(expected,actual,delta);
        }

        [TestMethod]
        public void Radius10_Area314_159265359()
        {
            double delta = 1E-10;
            Circle c = new Circle(10);
            double expected = 314.159265359;
            double actual = c.Area;
            Assert.AreEqual(expected, actual, delta);
        }
    }
}