using NUnit.Framework;

namespace IfScooters.Test
{
    public class ScooterRentTest
    {
        [Test]
        public void StartRent_RentANewScooter_ReturnsTrue()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            p.AddScooter("123", 2);
            s.StartRent("123");
            var q = p.GetScooterById("123");

            //Assert
            Assert.IsTrue(q.IsRented);
        }

        [Test]
        public void EndRent_ScooterIsAvailable_ReturnsIsRentedFalse()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            p.AddScooter("123", 2);
            s.StartRent("123");
            var q = p.GetScooterById("123");
            s.EndRent("123");

            //Assert
            Assert.IsFalse(q.IsRented);

        }

        [Test]
        public void EndRent_ScooterIsGivenBackToCalculateTurnover_ReturnsExpectedAmount()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            p.AddScooter("123", 2);
            s.StartRent("123");

            var actualTurnover = s.EndRent("123");
            
            //Assert
            Assert.AreEqual(2, actualTurnover);
        }

        [Test]
        public void CalculateIncome_5ScootersEnded_ShouldReturnTotalTurnover()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            p.AddScooter("123", 2);
            s.StartRent("123");
            p.AddScooter("134", 2);
            s.StartRent("134");
            p.AddScooter("156", 2);
            s.StartRent("156");
            p.AddScooter("181", 2);
            s.StartRent("181");
            p.AddScooter("222", 2);
            s.StartRent("222");

            var actualTurnover = s.CalculateIncome(1, true);

            //Assert
            Assert.AreEqual(10, actualTurnover);
        }

        [Test]
        public void CalculateIncome_RentedOutScootersAreNotIncluded_ShouldReturnTotalTurnover()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            p.AddScooter("123", 2);
            s.StartRent("123");
            p.AddScooter("134", 2);
            s.StartRent("134");
            p.AddScooter("156", 2);
            s.StartRent("156");
            p.AddScooter("181", 2);
            s.StartRent("181");
            p.AddScooter("222", 2);
            s.StartRent("222");

            var actualTurnover = s.CalculateIncome(1, false);

            //Assert
            Assert.AreEqual(0, actualTurnover);
        }

        [Test]
        public void CompanyNameProperty_IsCalledByGet_ReturnsChangedProperty()
        {
            //Arrange
            var p = new ScooterService();
            var s = new ScooterRent(p);

            //Act
            s.Name = "Bolt";

            //Assert
            Assert.AreEqual("Bolt", s.Name);
        }
    }
}
