using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass()]
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;

        [TestInitialize]

        public void SetUp()
        {
            _target = new CozaLozaWoza();
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfCoza_Pass()
        {
            //Arrange
            var num = 3;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("Coza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfLoza_Pass()
        {
            //Arrange
            var num = 5;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("Loza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfWoza_Pass()
        {
            //Arrange
            var num = 7;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("Woza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfCozaLoza_Pass()
        {
            //Arrange
            var num = 15;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("CozaLoza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfCozaWoza_Pass()
        {
            //Arrange
            var num = 21;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("CozaWoza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfLozaWoza_Pass()
        {
            //Arrange
            var num = 35;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual("LozaWoza ", result);
        }

        [TestMethod()]
        public void CozaLozaWozaNumCheck_IfNotCozaLozaWoza_Pass()
        {
            //Arrange
            var num = 13;
            //Act
            string result = _target.CozaLozaWozaNumCheck(num);
            //Assert
            Assert.AreEqual($"{num} ", result);
        }
    }
}