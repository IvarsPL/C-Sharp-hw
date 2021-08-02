using NUnit.Framework;

namespace Account.Test
{
    public class Tests
    {

        [Test]
        public void AccountConstructor_NewAccount_ReturnsTrue()
        {
            //Arrange
            var expectedBalance = 1000000;
            var expectedName ="Ivars";

            //Act
            var actual = new Account("Ivars", 1000000);

            //Assert
            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedBalance, actual.Balance());
        }

        [Test]
        public void NameProperty_ChangeName_ReturnsTrue()
        {
            //Arrange
            var expectedName = "Igors";

            //Act
            var actual = new Account("Ivars", 1000000);
            actual.Name = "Igors";

            //Assert
            Assert.AreEqual(expectedName, actual.Name);
        }

        [Test]
        public void Withdraw_HalfOfBalance_ReturnsTrue()
        {
            //Arrange
            var expectedBalance = 500;

            //Act
            var actual = new Account("Ivars", 1000);
            actual.Withdrawal(500);

            //Assert
            Assert.AreEqual(expectedBalance, actual.Balance());
        }

        [Test]
        public void Deposit_DoubleUpBalance_ReturnsTrue()
        {
            //Arrange
            var expectedBalance = 1000;

            //Act
            var actual = new Account("Ivars", 500);
            actual.Deposit(500);

            //Assert
            Assert.AreEqual(expectedBalance, actual.Balance());
        }

        [Test]
        public void ToString_NameAndBalance_ReturnsTrue()
        {
            //Arrange
            var expected = $"Ivars: 1000";


            //Act
            var actual = new Account("Ivars", 1000);
            var equals = actual.ToString();

            //Assert
            Assert.AreEqual(expected, equals);
        }
    }
}