using ShapeLibrary.Shapes;

namespace ShapeLibraryTests
{
    [TestClass]
    public class Triangle_IsRightAngled
    {
        [TestMethod]
        public void SideA_3_SideB_4_SideC_5_RightAngled_True()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle t = new Triangle(sideA, sideB, sideC);
            bool expected = true;
            bool actual = t.IsRightAngled;
            Assert.AreEqual(expected,actual);
        }
        
        [TestMethod]
        public void SideA_12_SideB_15_SideC_21_RightAngled_False()
        {
            double sideA = 12;
            double sideB = 15;
            double sideC = 21;
            Triangle t = new Triangle(sideA, sideB, sideC);
            bool expected = false;
            bool actual = t.IsRightAngled;
            Assert.AreEqual(expected, actual);
        }
    }
}