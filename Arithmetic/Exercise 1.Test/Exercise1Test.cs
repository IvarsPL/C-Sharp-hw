using NUnit.Framework;

namespace Exercise_1.Test
{
    public class Exercise1Test
    {

        [Test]
        public void CheckDigitsForFifteen_SumEqualsFifteen_ReturnsTrue()
        {
            //Arrange
            var caseOne = 7;
            var caseTwo = 8;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckDigitsForFifteen_DifferenceEqualsFifteen_ShouldReturnTrue()
        {
            //Arrange
            var caseOne = 22;
            var caseTwo = 7;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckDigitsForFifteen_OtherDifferenceEqualsFifteen_ShouldReturnTrue()
        {
            //Arrange
            var caseOne = 19;
            var caseTwo = 34;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckDigitsForFifteen_OneIsFifteen_ShouldReturnTrue()
        {
            //Arrange
            var caseOne = 15;
            var caseTwo = 34;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckDigitsForFifteen_OtherIsFifteen_ShouldReturnTrue()
        {
            //Arrange
            var caseOne = 232;
            var caseTwo = 15;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckDigitsForFifteen_NumbersDontMatchCriteria_ShouldReturnFalse()
        {
            //Arrange
            var caseOne = 232;
            var caseTwo = 123;

            //Act
            var actual = Exercise1.CheckDigitsForFifteen(caseOne, caseTwo);

            //Assert
            Assert.IsFalse(actual);
        }

    }
}