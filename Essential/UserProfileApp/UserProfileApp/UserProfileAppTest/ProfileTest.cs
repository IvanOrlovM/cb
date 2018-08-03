using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserProfileApp;

namespace UserProfileAppTest
{
    [TestClass]
    public class ProfileTest
    {
        private Profile _target;

        [TestInitialize]
        public void Init()
        {
            var user = new User
            {
                Name = "Vasya",
                Age = 33
            };
            _target = new Profile(user);
        }

        [TestMethod]
        public void CreateDateTest()
        {
            Assert.IsTrue(_target.CreateDate <= DateTime.Now);
        }
    }
}