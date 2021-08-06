using Exercise_5;
using NUnit.Framework;

namespace Exercise5.Test
{
    public class Tests
    {
        [Test]
        public void DateConstructor_RandomDay_ReturnsExpectedNewDate()
        {
            //Arrange
            var expectedMonth = 12;
            var expectedYear = 2012;
            var expectedDay = 21;
            //Act
            var mahDay = new Date(21, 2012, 12);
            //Assert
            Assert.AreEqual(expectedDay, mahDay.Day);
            Assert.AreEqual(expectedMonth, mahDay.Month);
            Assert.AreEqual(expectedYear, mahDay.Year);
        }

        [Test]
        public void DisplayDate_RandomDay_ReturnsExpectedDateAsString()
        {
            //Arrange
            var expected = $"{12:00}/{21:00}/{2012:0000}";

            //Act
            var mahDay = new Date(21, 2012, 12);
            var actual = mahDay.DisplayDate();

            //Arrange
            Assert.AreEqual(expected,actual);

        }
    }
}