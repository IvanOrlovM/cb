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
            var firstName = "";
            var lastName = "";
            _target = new Employee(firstName, lastName);
        }

        [TestMethod]
        public void Test()
        {

        }
    }
}
