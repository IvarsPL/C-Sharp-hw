using NUnit.Framework;
using GravityCalculator;

namespace GravityCalculator.test
{
    public class Tests
    {
        [Test]
        public void FinalPosition_Input_ReturnsTrue()
        {
            //Arrange
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            var equals = -490.5;

            //Act
            var actual = GravityCalculator.FinalPosition(gravity, initialVelocity, fallingTime, initialPosition);

            //Assert
            Assert.AreEqual(equals, actual);
        }
    }
}