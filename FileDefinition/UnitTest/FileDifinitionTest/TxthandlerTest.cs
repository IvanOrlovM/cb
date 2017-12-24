using System;
using FileDefinition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDifinitionTest
{
    [TestClass]
    public class TxtHandlerTest
    {
        private XmlHandler _target;
        private string _path = @"FileDefinition.txt";

        [TestInitialize]
        public void Init()
        {
            _target = new XmlHandler(_path);
        }

        [TestMethod]
        //[ExpectedException(typeof(NotImplementedException))]
        public void OpenTest()
        {
            _target.Open();
            Assert.AreEqual("my file", _target.Value);
        }

        [TestMethod]
        public void SaveTest()
        {
            var value = Guid.NewGuid().ToString("N").ToUpper();
            _target.Value = value;
            _target.Save();
            _target.Open();
            Assert.AreEqual(value, _target.Value);
        }
    }
}
