using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hierarchy.Tests
{
    [TestClass()]
    public class HierarchyTests
    {
        private List<Animal> animals = new List<Animal>();
        private List<Food> foods = new List<Food>();

        [TestInitialize]
        public void SetUp()
        {
            animals.Add(new Cat("Name", "type", 25.2, 1, "livingRegion", "breed"));
            animals.Add(new Tiger("Name", "type", 25.2, 1, "livingRegion"));
            animals.Add(new Mouse("Name", "type", 25.2, 1, "livingRegion"));
            foods.Add(new Meat(3));
            foods.Add(new Vegetable(2));
        }

        [TestMethod()]
        public void AnimalToStringTest()
        {
            //Arrange
            string resultCat = "Type: type, name: Name, weight: 25,2kg, living region: livingRegion, breed: breed.";
            string resultTigerMouse = "Type: type, name: Name, weight: 25,2kg, living region: livingRegion";

            foreach (Animal animal in animals)
            {
                if (animals[0] == animal)
                {
                    Assert.AreEqual(resultCat, animal.ToString());
                }
                else
                {
                    Assert.AreEqual(resultTigerMouse, animal.ToString());
                }
            }
        }

        [TestMethod()]
        public void CatTigerMouseEatFoodTest()
        {
            //Arrange
            string resultDontEat = "type are not eating that type of food!";
            string resultMeat = "Name the type ate 3kg of meat";
            string resultVegetable = "Name the type ate 2kg of vegetables";

            foreach (Animal animal in animals)
            {
                if (animals[0] == animal)
                {
                    //Assert
                    Assert.AreEqual(resultMeat, animal.Eat(foods[0]));
                    Assert.AreEqual(resultVegetable, animal.Eat(foods[1]));
                }
                else if (animals[1] == animal)
                {
                    //Assert
                    Assert.AreEqual(resultMeat, animal.Eat(foods[0]));
                    Assert.AreEqual(resultDontEat, animal.Eat(foods[1]));
                }
                else
                {
                    //Assert
                    Assert.AreEqual(resultDontEat, animal.Eat(foods[0]));
                    Assert.AreEqual(resultVegetable, animal.Eat(foods[1]));
                }
            }
        }

        [TestMethod()]
        public void DisplayAnimalTest()
        {
            //Arrange
            string resultCat = "type [Name, breed, 25,2, livingRegion, 1]";
            string resultTigerMouse = "type [Name, 25,2, livingRegion, 1]";

            foreach (Animal animal in animals)
            {
                if (animal == animals[0])
                {
                    //Assert
                    Assert.AreEqual(resultCat, animal.DisplayAnimal());
                }
                else
                {
                    //Assert
                    Assert.AreEqual(resultTigerMouse, animal.DisplayAnimal());
                }
            }
        }

        [TestMethod()]
        public void MakeSoundTest()
        {
            //Arrange
            string resultCat = "Meeeow";
            string resultTiger = "ROOOAAR";
            string resultMouse = "Pipipipi";

            foreach (Animal animal in animals)
            {
                if (animal == animals[0])
                {
                    //Assert
                    Assert.AreEqual(resultCat, animal.MakeSound());
                }
                else if (animal == animals[1])
                {
                    //Assert
                    Assert.AreEqual(resultTiger, animal.MakeSound());
                }
                else
                {
                    //Assert
                    Assert.AreEqual(resultMouse, animal.MakeSound());
                }
            }
        }
    }
}