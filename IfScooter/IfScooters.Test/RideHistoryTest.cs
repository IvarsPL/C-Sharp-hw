using System;
using NUnit.Framework;

namespace IfScooters.Test
{
    class RideHistoryTest
    {
        [Test]
        public void RideHistoryConstructor_CreateNewInstance_ReturnsNewInstance()
        {
            //Arrange
            var expectedTurnover = 0;
            var expectedId = "123";

            //Act
            var actual = new RideHistory("123");
            //Assert
            Assert.AreEqual(expectedId, actual.Id);
            Assert.AreEqual(expectedTurnover, actual.Turnover);
        }

        [Test]
        public void CalculateScooterRideTime_MoreThanOneDay_ReturnsCorrectPrice()
        {
            //Arrange
            var expectedMin = 23;
            var expectedDays = 1;
            var compare = new RideHistory("123");
            //Act
            compare.EndDateTime = new DateTime(2021,8,5, 22, 23,23);
            compare.CalculateScooterRideTime();
            //Assert
            Assert.AreEqual(expectedDays, compare.RideMinutes); //izlabot pasu get metodi
            Assert.AreEqual(expectedDays, compare.RideDays); 
        }
    }
}
