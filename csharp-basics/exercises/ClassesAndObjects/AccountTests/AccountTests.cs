using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Account.Tests
{
    [TestClass()]
    public class AccountTests
    {
        private Account _target;

        [TestInitialize]
        public void SetUp()
        {
            _target = new Account("Ron's account", 30.00);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            string reference = "Ron's account: 30";
            //Act
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(reference, result);
        }

        [TestMethod()]
        public void WithdrawalTest()
        {
            //Arrange
            string reference = "Ron's account: 20";
            //Act
            _target.Withdrawal(10.00);
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(reference, result);
        }

        [TestMethod()]
        public void DepositTest()
        {
            //Arrange
            string reference = "Ron's account: 40";
            //Act
            _target.Deposit(10.00);
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(reference, result);
        }

        [TestMethod()]
        public void BalanceTest()
        {
            //Arrange
            double balance = 30;
            //Act
            var result = _target.Balance();
            //Assert
            Assert.AreEqual(balance, result);
        }

        [TestMethod()]
        public void NameSetTest()
        {
            //Arrange
            string reference = "John's account: 30";
            //Act
            _target.Name = "John's account";
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(reference, result);
        }
    }
}