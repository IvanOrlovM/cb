using System;
using L1T4FiguresApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L1T4FigureAppTest
{
    [TestClass]
    public class FigureTest
    {
        private Figure _target;

        [TestInitialize]
        public void Init()
        {
            var pointA = new Point("A", 4, 5);
            var pointB = new Point("B", 5, 5);
            var pointC = new Point("C", 5, 8);
            var pointD = new Point("D", 4, 8);
            _target = new Figure("name", pointA, pointB, pointC, pointD);
        }

        [TestMethod]
        public void LenghtSideTest()
        {
            var actual = _target.LenghtSide(new Point("A", 3, -4), new Point("B", -6, 5));
            Assert.AreEqual(8.0, actual);
        }
    }
}
