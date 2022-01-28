using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass()]
    public class DateTests
    {
        private Date _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new Date(2022, 1, 28);
        }
        [TestMethod()]

        public void DisplayDateTest()
        {
            //Arrange
            string date = "1/28/2022";
            //Act
            var result = _target.DisplayDate();
            //Assert
            Assert.AreEqual(date, result);
        }
    }
}