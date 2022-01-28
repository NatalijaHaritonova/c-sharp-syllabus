using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise8.Tests
{
    [TestClass()]
    public class SalaryTests
    {
        private Salary _target;
        [TestInitialize]

        public void SetUp()
        {
            _target = new Salary();
        }

        [TestMethod()]
        public void TotalPayTest_BasePay()
        {
            //Arrange
            double pay = 8.2;
            int hours = 35;
            //Act
            var result = _target.TotalPay(pay, hours);
            //Assert
            Assert.AreEqual(287, result);
        }

        [TestMethod()]
        public void TotalPayTest_ExeptionPay()
        {
            //Arrange
            double pay = 7.2;
            int hours = 35;
            //Act
            Exception result = Assert.ThrowsException<Exception>(() => _target.TotalPay(pay, hours));
            //Assert
            Assert.AreEqual("Error - Pay per hour is too low", result.Message);
        }

        [TestMethod()]
        public void TotalPayTest_ExeptionHours()
        {
            //Arrange
            double pay = 10.0;
            int hours = 75;
            //Act
            Exception result = Assert.ThrowsException<Exception>(() => _target.TotalPay(pay, hours));
            //Assert
            Assert.AreEqual("Error - Employee worked too many hours", result.Message);
        }
    }
}