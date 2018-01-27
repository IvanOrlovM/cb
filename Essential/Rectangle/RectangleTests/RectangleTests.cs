using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleTests
{
    [TestClass]
    public class RectangleTests
    {
        private Rectangle.Rectangle _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Rectangle.Rectangle(2, 3);
        }

        [TestMethod]
        public void AreaCalculatorTest()
        {
            double expected = _target.AreaCalculator();
            Assert.AreEqual(expected, 6);
        }

        [TestMethod]
        public void PerimeterCalculatorTest()
        {
            double expected = _target.PerimeterCalculator();
            Assert.AreEqual(expected, 10);
        }

        [TestMethod]
        public void AreaTest()
        {
            Assert.AreEqual(_target.Area, 6);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Assert.AreEqual(_target.Perimeter, 10);
        }
    }
}