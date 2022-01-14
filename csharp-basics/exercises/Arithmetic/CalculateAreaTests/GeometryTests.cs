using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateArea.Tests
{
    [TestClass()]
    public class GeometryTests
    {   
        [TestMethod()]
        public void AreaOfCircleTest_R10()
        {
            //Arrange
            decimal radius = 10;
            //Act
            var result = Geometry.AreaOfCircle(radius);
            //Assert
            Assert.AreEqual(314, result);
        }

        [TestMethod()]
        public void AreaOfRectangleTest()
        {
            //Arrange
            decimal length = 10;
            decimal width = 3;
            //Act
            var result = Geometry.AreaOfRectangle(length, width);
            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod()]
        public void AreaOfTriangleTest()
        {
            //Arrange
            decimal ground = 15;
            decimal h = 4;
            //Act
            var result = Geometry.AreaOfTriangle(ground, h);
            //Assert
            Assert.AreEqual(30, result);
        }
    }
}