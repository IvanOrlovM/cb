using System;
using ArithmeticForLambda;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticForLabdaTests
{
    [TestClass]
    public class CalcTest
    {
        private Calc _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Calc();
        }

        [TestMethod]
        public void AddTest()
        {
            double actual = _target.Add(2.5, 1.35);
            Assert.AreEqual(expected: 3.85, actual: actual);
        }

        [TestMethod]
        public void SubTest()
        {
            double actual = _target.Sub(2.5, 1.35);
            Assert.AreEqual(expected: 1.15, actual: actual);
        }

       [TestMethod]
        public void MulTest()
        {
            double actual = _target.Mul(2.5, 1.35);
            Assert.AreEqual(expected: 3.375, actual: actual);
        }

        [TestMethod]
        public void DivTest()
        {
            double actual = _target.Div(9, 2);
            Assert.AreEqual(expected: 4.5, actual: actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivExceptionTest()
        {
            double actual = _target.Div(9, 0);
        }
    }
}
