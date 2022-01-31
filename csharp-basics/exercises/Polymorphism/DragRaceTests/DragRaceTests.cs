using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DragRace.Tests
{
    [TestClass()]
    public class DragRaceTests
    {
        private List<ICar> cars = new List<ICar>();
        private List<INitro> nitros = new List<INitro>();

        [TestInitialize]
        public void SetUp()
        {
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Subaru());
            cars.Add(new Tesla());
            cars.Add(new VW());
            nitros.Add(new Lexus());
            nitros.Add(new Subaru());
        }

        [TestMethod()]
        public void SpeedUpTest()
        {
            //Arrange
            int speed = 10;

            foreach (ICar car in cars)
            {
                //Act
                int result = car.SpeedUp(10);
                //Assert
                Assert.AreEqual(speed, result);
            }
        }

        [TestMethod()]
        public void SlowDownTest()
        {
            //Arrange
            var speed = -10;

            foreach (ICar car in cars)
            {
                //Act
                int result = car.SlowDown(10);
                //Assert
                Assert.AreEqual(speed, result);
            }
        }

        [TestMethod()]
        public void ShowCurrentSpeedTest()
        {
            //Arrange
            string speed = "0";

            foreach (ICar car in cars)
            {
                //Act
                string result = car.ShowCurrentSpeed();
                //Assert
                Assert.AreEqual(speed, result);
            }
        }

        [TestMethod()]
        public void StartEngineTest()
        {
            //Arrange
            string soundVW = "Trtrtr.....";
            string soundTesla = "-- silence ---";
            string soundSubaru = "BRRM...BRRM..BRRR...";
            string soundLexusBmwAudi = "Rrrrrrr.....";

            foreach (ICar car in cars)
            {
                if (car.StartEngine() == soundVW)
                {
                    //Act
                    string result = car.StartEngine();
                    //Assert
                    Assert.AreEqual(soundVW, result);
                }
                else if (car.StartEngine() == soundTesla)
                {
                    //Act
                    string result = car.StartEngine();
                    //Assert
                    Assert.AreEqual(soundTesla, result);
                }
                else if (car.StartEngine() == soundSubaru)
                {
                    //Act
                    string result = car.StartEngine();
                    //Assert
                    Assert.AreEqual(soundSubaru, result);
                }
                else if (car.StartEngine() == soundLexusBmwAudi)
                {
                    //Act
                    string result = car.StartEngine();
                    //Assert
                    Assert.AreEqual(soundLexusBmwAudi, result);
                }

            }
        }

        [TestMethod()]
        public void UseNitrousOxideEngineTest()
        {
            //Arrange
            int speed1 = 40;
            int speed2 = 50;

            foreach (INitro nitro in nitros)
            {
                if (nitro == nitros[0])
                {
                    //Assert
                    Assert.AreEqual(speed1, nitro.UseNitrousOxideEngine());
                }
                else
                {
                    //Assert
                    Assert.AreEqual(speed2, nitro.UseNitrousOxideEngine());
                }
            }
        }
    }
}