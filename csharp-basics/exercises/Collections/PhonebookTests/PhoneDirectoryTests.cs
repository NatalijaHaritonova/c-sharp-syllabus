using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBook.Tests
{
    [TestClass()]
    public class PhoneDirectoryTests
    {
        public PhoneDirectory _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod()]
        public void PutNumberTest()
        {
            //Arrange
            string number = "2736472";
            string name = "Alex";
            //Act
            _target.PutNumber(name, number);
            //Assert
            Assert.AreEqual(number, _target.GetNumber(name));
        }

        [TestMethod()]
        public void GetNumberNullTest()
        {
            //Act
            var result = _target.GetNumber("Alex");
            //Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void GetNumberNotNullTest()
        {
            //Arrange
            string number = "2736472";
            string name = "Alex";
            _target.PutNumber(name, number);
            //Act
            var result = _target.GetNumber("Alex");
            //Assert
            Assert.AreEqual(number, result);
        }

        [TestMethod()]
        public void DataContainsNameTrueTest()
        {
            //Arrange
            string number = "2736472";
            string name = "Alex";
            _target.PutNumber(name, number);
            //Act
            bool result = _target.DataContainsName(name);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void DataContainsNameFalseTest()
        {
            //Arrange
            string name = "Alex";
            //Act
            bool result = _target.DataContainsName(name);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}