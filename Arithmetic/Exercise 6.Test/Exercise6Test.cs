using NUnit.Framework;

namespace Exercise_6.Test
{
    public class Exercise6Test
    {
        [Test]
        public void CozaWozaLoza_NumberToCheckIs15_ShouldReturnCozaLoza()
        {
            //Arrange
            var equal = "CozaLoza ";
            var numberToCheck = 15;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs7_ShouldReturnWoza()
        {
            //Arrange
            var equal = "Woza ";
            var numberToCheck = 7;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs5_ShouldReturnLoza()
        {
            //Arrange
            var equal = "Loza ";
            var numberToCheck = 5;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs3_ShouldReturnCoza()
        {
            //Arrange
            var equal = "Coza ";
            var numberToCheck = 3;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs11_ShouldReturnNumberAndLineBreak()
        {
            //Arrange
            var equal = "11\n";
            var numberToCheck = 11;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs33_ShouldReturnCozaAndLineBreak()
        {
            //Arrange
            var equal = "Coza\n";
            var numberToCheck = 33;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs55_ShouldReturnLozaAndLineBreak()
        {
            //Arrange
            var equal = "Loza\n";
            var numberToCheck = 55;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIs77_ShouldReturnWozaAndLineBreak()
        {
            //Arrange
            var equal = "Woza\n";
            var numberToCheck = 77;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }

        [Test]
        public void CozaWozaLoza_NumberToCheckIsOtherNumber_ShouldReturnNumber()
        {
            //Arrange
            var equal = "4 ";
            var numberToCheck = 4;

            //Act
            var actual = Exercise6.CozaWozaLoza(numberToCheck);

            //Assert
            Assert.AreEqual(equal, actual);
        }
    }
}