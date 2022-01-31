using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass()]
    public class ProductTests
    {
        private Product _target;
        [TestInitialize]
        public void SetUp()
        {
            _target = new Product("Name", 25.00, 3);
        }

        [TestMethod()]
        public void PrintProductTest()
        {
            //Arrange
            string str = "Name, price 25, amount 3";
            //Act
            string result = _target.PrintProduct();
            //Assert
            Assert.AreEqual(str, result);
        }

        [TestMethod()]
        public void ChangePriceTest()
        {
            //Arrange
            string str = "Name, price 30, amount 3";
            //Act
            _target.ChangePrice();
            string result = _target.PrintProduct();
            //Assert
            Assert.AreEqual(str, result);
        }

        [TestMethod()]
        public void ChangeAmountTest()
        {
            //Arrange
            string str = "Name, price 25, amount 5";
            //Act
            _target.ChangeAmount();
            string result = _target.PrintProduct();
            //Assert
            Assert.AreEqual(str, result);
        }
    }
}