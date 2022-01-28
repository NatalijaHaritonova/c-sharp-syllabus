using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new Calculator();
        }

        [TestMethod()]
        public void GravCalculatorTest_Time10s_Pass()
        {
            //Arrange
            double gravity = 9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            //Act
            var result = _target.GravCalculator(gravity, fallingTime, initialVelocity, initialPosition);
            //Assert
            Assert.AreEqual(490.5, result);
        }

        [TestMethod()]
        public void GravCalculatorTest_Time15s_pass()
        {
            //Arrange
            double gravity = 9.81;
            double initialVelocity = 0.0;
            double fallingTime = 15.0;
            double initialPosition = 0.0;
            //Act
            var result = _target.GravCalculator(gravity, fallingTime, initialVelocity, initialPosition);
            //Assert
            Assert.AreEqual(1103,6, result);
        }
    }
}