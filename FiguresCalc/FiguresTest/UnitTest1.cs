using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresCalc;

namespace FiguresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcAreaRectangle_Multy5On5_25returnedethod1()
        {
            double value1 = 5;
            double value2 = 12;
            double expected = 60;

            Shape2D rectangle = new Rectangle("Прямоугольник");
            var result = rectangle.Area(value1, value2);
            Assert.AreEqual(expected, result);
        }
    }
}
