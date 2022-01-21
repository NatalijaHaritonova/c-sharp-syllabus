using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordCount.Tests
{
    [TestClass()]
    public class WCountTests
    {
        private WCount _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new WCount();
        }

        [TestMethod()]
        public void LineCountTest()
        {
            //Arrange
            List<string> lines = new List<string> {"Hello hello hello,", "hello, hello, hello"};
            //Act
            int result = _target.LineCount(lines);
            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void WordCountTest()
        {
            //Arrange
            List<string> lines = new List<string> { "Hello hello hello,", "hello, hello, hello" };
            //Act
            int result = _target.WordCount(lines);
            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod()]
        public void CharCountTest()
        {
            //Arrange
            List<string> lines = new List<string> { "Hello hello hello,", "hello, hello, hello" };
            //Act
            int result = _target.CharCount(lines);
            //Assert
            Assert.AreEqual(37, result);
        }
    }
}