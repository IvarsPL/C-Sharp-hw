using NUnit.Framework;

namespace WordCount.Test
{
    public class Tests
    {
        [Test]
        public void CharCounter_CheckingNormalChars_ShouldReturnTrue()
        {
            //Arrange
            var text =
                "Poor naked wretches, wheresoe'er you are,That bide the pelting of this pitiless storm, How shall your houseless heads and unfed sides, Your loop'd and window'd raggedness, defend you From seasons such as these ?  O, I have ta'en Too little care of this!";
            var expected = 198;
            //Act
            var actual = WordCount.CharCounter(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordCounter_CountingWords_ShouldReturnTrue()
        {
            //Arrange
            var text =
                "Poor naked wretches, wheresoe'er you are,That bide the pelting of this pitiless storm, How shall your houseless heads and unfed sides, Your loop'd and window'd raggedness, defend you From seasons such as these ?  O, I have ta'en Too little care of this!";
            var expected = 43;
            //Act
            var actual = WordCount.WordCouner(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}