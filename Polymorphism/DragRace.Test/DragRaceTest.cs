using NUnit.Framework;

namespace DragRace.Test
{
    public class Tests
    {
        [Test]
        public void TeslaConstructor_CreateNewInstance_ReturnsNewTeslaInstance()
        {
            //Arrange
            var expected = "0";
            //Act
            var actual = new Tesla();
            //Assert
            Assert.AreEqual(expected, actual.ShowCurrentSpeed());
        }
        [Test]
        public void SpeedUp_CallFourTimes_ReturnsIncreasedSpeedProperty()
        {
            var actual = new Tesla();
            var expected = "4";
            //Act
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            //Assert
            Assert.AreEqual(expected, actual.ShowCurrentSpeed());
        }

        [Test]
        public void SlowDown_CallOnce_ReturnsDecreasedSpeedProperty()
        {
            var actual = new Tesla();
            var expected = "2";
            //Act
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SpeedUp();
            actual.SlowDown();
            //Assert
            Assert.AreEqual(expected, actual.ShowCurrentSpeed());
        }

        [Test]
        public void StartEngine_CallOnce_ReturnsExpectedSoundAsString()
        {
            var actual = new Tesla();
            var expected = "-- silence ---";
            //Act
            var equals = actual.StartEngine();
            //Assert
            Assert.AreEqual(expected, equals);
        }

        [Test]
        public void UseNitrousOxideEngine_IfCarImplementsINitrousCarInterface_ReturnsExpectedBoostInSpeed()
        {
            //Arrange
            var actual = new Lexus();
            var expected = "5";
            //Act
            actual.UseNitrousOxideEngine();
            var equals = actual.ShowCurrentSpeed();
            //Assert
            Assert.AreEqual(expected, equals);
        }
    }
}