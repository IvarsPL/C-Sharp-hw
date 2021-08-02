using NUnit.Framework;

namespace Exercise1.Test
{
    public class Tests
    {
        [Test]
        public void ProductConstructor_InputStandardProduct_ReturnsTrue()
        {
            //Arrange
            var expectedName = "Potatoe";
            var expectedPrice = 12.54;
            var expectedAmount = 4;
            //Act
            var potato = new Product("Potatoe", 12.54, 4);
            //Assert
            Assert.AreEqual(expectedAmount,potato.Amount);
            Assert.AreEqual(expectedName, potato.Name);
            Assert.AreEqual(expectedPrice, potato.PriceAtStart);
        }

        [Test]
        public void PrintProduct_ProductNameAndPrice_ReturnsTrue()
        {
            //Arrange
            var expectedName = "Potatoe";
            var expectedPrice = 12.54;
            var expectedAmount = 4;
            var expected = $"{expectedName}, price {expectedPrice:0.00} EUR, amount {expectedAmount}";
            //Act
            var potato = new Product("Potatoe", 12.54, 4);
            var actual = potato.PrintProduct();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PriceChange_NewPrice_ReturnsTrue()
        {
            //Arrange
            var expectedPrice = 4.44;
            //Act
            var potato = new Product("Potatoe", 12.54, 4);
            potato.PriceChange(4.44);
            //Assert
            Assert.AreEqual(expectedPrice, potato.PriceAtStart);
        }

        [Test]
        public void AmountChange_NewAmount_ReturnsTrue()
        {
            //Arrange
            var expectedAmount = 44;
            //Act
            var potato = new Product("Potatoe", 12.54, 4);
            potato.AmountChange(44);
            //Assert
            Assert.AreEqual(expectedAmount, potato.Amount);
        }
    }
}