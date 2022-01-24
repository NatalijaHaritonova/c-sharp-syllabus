using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlightPlanner.Tests
{
    [TestClass()]
    public class FPlannerTests
    {
        private FPlanner _target;

        [TestInitialize]
        public void SetUp()
        {
            var flights = new Dictionary<string, List<string>>
            {
                {"1", new List<string> {"2", "3"}},
                {"2", new List<string> {"1", "3"}},
                {"3", new List<string> {"1", "2"}}
            };
            _target = new FPlanner(flights);
        }

        [TestMethod()]
        public void ShowAllCitiesTest()
        {
            //Arrange
            var cities = $"1\n2\n3\n";
            //Act
            var result = _target.ShowAllCities();
            //Assert
            Assert.AreEqual(cities, result);
        }

        [TestMethod()]
        public void ShowAvailableCitiesTest()
        {
            //Arrange
            var city = "1";
            //Act
            var result = _target.ShowAvailableCities(city);
            //Assert
            Assert.AreEqual($"2\n3\n", result);
        }
    }
}