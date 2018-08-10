using System;
using L2T2ConverterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2T2ConverterAppTest
{
    [TestClass]
    public class ConverterTest
    {
        private Converter _target;

        [TestInitialize]
        public void Init()
        {
            double usd = 27.4;
            double eur = 30.9;
            double rub = 0.4;
            _target = new Converter(usd, eur, rub);
        }

        [TestMethod]
        public void ConvertUsdTest()
        {
            double actual = _target.Convert(274.0, CurrencyType.Usd);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void ConvertEurTest()
        {
            double actual = _target.Convert(309.0, CurrencyType.Eur);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertNoneTest()
        {
            _target.Convert(0, CurrencyType.None);
        }

        [TestMethod]
        public void ConvertRubTest()
        {
            double actual = _target.Convert(4.0, CurrencyType.Rub);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void ConvertUsdToUahTest()
        {
            double actual = _target.ConvertToUah(10, CurrencyType.Usd);
            Assert.AreEqual(274.0, actual);
        }

        [TestMethod]
        public void ConvertEurToUahTest()
        {
            double actual = _target.ConvertToUah(10, CurrencyType.Eur);
            Assert.AreEqual(309.0, actual);
        }

        [TestMethod]
        public void ConvertRubToUahTest()
        {
            double actual = _target.ConvertToUah(10, CurrencyType.Rub);
            Assert.AreEqual(4.0, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToUahNoneTest()
        {
            _target.ConvertToUah(0, CurrencyType.None);
        }
    }
}