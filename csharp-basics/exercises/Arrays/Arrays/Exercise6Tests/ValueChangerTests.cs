using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Exercise6.Tests
{
    [TestClass()]
    public class ValueChangerTests
    {
        private ValueChanger _target;
        [TestInitialize]
        public void SetUp()
        {
            _target = new ValueChanger();
        }

        [TestMethod()]
        public void ChangeValuesTest()
        {
            //Arrange
            var value = 15;
            var position = 6;
            //Act
            _target.ChangeValues(value, position);
            var result = Array.IndexOf(_target.arr, value);
            //Assert
            Assert.AreEqual(position, result);
        }

        [TestMethod()]
        public void AddValuesTest()
        {
            //Arrange
            var count = 10;
            //Act
            _target.AddValues();
            var result = _target.arr.Count();
            //Assert
            Assert.AreEqual(count, result);
        }

        [TestMethod()]
        public void AddValuesTest2()
        {
            //Arrange
            //Act
            _target.AddValues();
            bool result = _target.arr[7] is Int32;
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}