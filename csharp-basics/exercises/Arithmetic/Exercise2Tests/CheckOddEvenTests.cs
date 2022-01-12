using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Tests
{
    [TestClass()]
    public class CheckOddEvenTests
    {
        private CheckOddEven _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new CheckOddEven();
        }

        [TestMethod()]
        public void OddOrEven_CheckIfOdd()
        {
            //Arrange
            var num = 7;
            //Act
            string result = _target.OddOrEven(num);
            //Assert
            Assert.AreEqual("Odd Number", result);
        }

        [TestMethod()]
        public void OddOrEven_CheckIfEven()
        {
            //Arrange
            var num = 4;
            //Act
            string result = _target.OddOrEven(num);
            //Assert
            Assert.AreEqual("Even Number", result);
        }
    }
}