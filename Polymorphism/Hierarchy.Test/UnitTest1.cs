using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;
using NUnit.Framework;

namespace Hierarchy.Test
{
    public class Tests
    {
        [Test]
        public void CatConstructor_CreateNewInstance_ReturnsTrue()
        {
            //Arrange
            var type = "Cat";
            var name = "Tom";
            var animalWeight = 10.2;
            var region = "home";
            var breed = "random";
            //Act
            var actual = new Cat("Cat", "Tom", 10.2, "home", "random");

            //Assert
            Assert.AreEqual(type, actual._animalType);
            Assert.AreEqual(name, actual._animalName);
            Assert.AreEqual(animalWeight, actual._animalWeight);
            Assert.AreEqual(region, actual._livingRegion);
            Assert.AreEqual(breed, actual._breed);
        }

        [Test]
        public void EatFood_AddFoodTwoTimes_ReturnTrue()
        {
            //Arrange
            var equals = 5;
            //Act
            var actual = new Cat("Cat", "Tom", 10.2, "home", "random");
            var food = new Meat("Meat", 5);
            actual.EatFood(food);
            //Assert
            Assert.AreEqual(equals, actual._foodEaten);

        }

    }
}