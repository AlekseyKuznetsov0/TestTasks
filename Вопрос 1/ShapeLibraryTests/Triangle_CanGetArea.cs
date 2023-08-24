using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestClass]
    public class Triangle_CanGetArea
    {
        [TestMethod]
        public void SideA_3_SideB_4_SideC_5_Area_6()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle t = new Triangle(sideA, sideB, sideC);
            double expected = 6;
            double actual = t.Area;
            double delta = 1E-13;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void SideA_12_SideB_15_SideC_21_Area_88_1816307401944()
        {
            double sideA = 12;
            double sideB = 15;
            double sideC = 21;
            Triangle t = new Triangle(sideA, sideB, sideC);
            double expected = 88.1816307401944;
            double actual = t.Area;
            double delta = 1E-15;
            Assert.AreEqual(expected, actual,delta);
        }
    }
}