using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileApp;

namespace UserProfileAppTest
{
    [TestClass]
    public class UserTest
    {
        private User _target;

        [TestInitialize]
        public void Init()
        {
            _target = new User
            {
                Login = "Login",
                Name = "Name",
                SName = "SName",
                Age = 19
            };
        }

        [TestMethod]
        public void ToStringTest()
        {
            var actual = _target.ToString();
            Assert.AreEqual("Login: Login, Name: Name, SName: SName, Age: 19", actual);
        }
    }
}
