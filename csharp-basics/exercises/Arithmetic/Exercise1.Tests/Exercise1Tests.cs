using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;
using System;

namespace Exercise1.Tests
{
    [TestClass]
    public class Exercise1Tests
    {
        private Is15Check _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new Is15Check();
        }

        [TestMethod]
        public void Is15_InputIs15_ReturnsTrue()
        {
            //Arrange
            var num1 = 3;
            var num2 = 4;
            //Act
            var result = _target.Is15(num1, num2);
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
