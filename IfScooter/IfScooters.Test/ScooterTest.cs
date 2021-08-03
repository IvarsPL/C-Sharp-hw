using NUnit.Framework;

namespace IfScooters.Test
{
    public class ScooterTest
    {
        [Test]
        public void PropertyInitializer_SetNewValues_ReturnTrue()
        {
            //Arrange
            var expected = true;
            var expectedTurnover = 100;

            //Act
            var myScootie = new Scooter("123", 12) {IsRented = true, Turnover = 100};

            //Assert
            Assert.AreEqual(expected, myScootie.IsRented);
            Assert.AreEqual(expectedTurnover, myScootie.Turnover);
        }

    }
}
