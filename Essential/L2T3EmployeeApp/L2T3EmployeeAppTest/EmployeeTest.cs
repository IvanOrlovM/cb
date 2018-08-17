using System;
using L2T3EmployeeApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace L2T3EmployeeAppTest
{
    [TestClass]
    public class EmployeeTest
    {
        private Employee _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Employee("Ivan", "Orlov", Positions.TechLiad);
        }

        [TestMethod]
        public void GetSallaryTest()
        {
            var actual = _target.GetSallary();
            Assert.AreEqual(2240, actual);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual(actual = "_firstName: Ivan, _lastName: Orlov, _position: TechLiad", actual);
        }   
    }
}
