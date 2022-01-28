using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass()]
    public class Is15CheckTests
    {
        private Is15Check _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new Is15Check();
        }

        [TestMethod()]
        public void Is15Test_Sum15_ReturnTrue()
        {
            //Arrange
            var num1 = 3;
            var num2 = 12;
            //Act
            var result = _target.Is15(num1, num2);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Is15Test_Not15_ReturnFalse()
        {
            //Arrange
            var num1 = 3;
            var num2 = 1;
            //Act
            var result = _target.Is15(num1, num2);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void Is15Test_DifferenceIs15_ReturnTrue()
        {
            //Arrange
            var num1 = 27;
            var num2 = 12;
            //Act
            var result = _target.Is15(num1, num2);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Is15Test_OneNumIs15_ReturnTrue()
        {
            //Arrange
            var num1 = 15;
            var num2 = 12;
            //Act
            var result = _target.Is15(num1, num2);
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}