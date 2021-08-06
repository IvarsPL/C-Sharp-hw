using NUnit.Framework;

namespace Exercise_2.Test
{
    public class Exercise2Test
    {
        [Test]
        public void OddOrEven_EvenNumber_ShouldReturnTrue()
        {
            //Arrange
            var expected = "Even";
            //Act
            var actual = Exercise2.OddOrEven(12);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OddOrEven_OddNumber_ShouldReturnTrue()
        {
            //Arrange
            var expected = "Odd";
            //Act
            var actual = Exercise2.OddOrEven(111);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}