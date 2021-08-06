using NUnit.Framework;
using System;

namespace CalculateArea.Test
{
    public class CalculateAreaTest
    {
        [Test]
        public void AreaOfCircle_ProperNumbers_ReturnsExpectedValue()
        {
            //Arrange
            var expected = 50.27;

            //Act
            var actual = Geometry.AreaOfCircle(4);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfCircle_WrongInput_ReturnsOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfCircle(-9));
        }

        [Test]
        public void AreaOfRectangle_ProperNumbers_ReturnsExpectedValue()
        {
            //Arrange
            var expected = 35.88;

            //Act
            var actual = Geometry.AreaOfRectangle((decimal)4.6, (decimal)7.8);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfRectangle_WrongInputHeight_ReturnsOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfRectangle(-9, 20));
        }

        [Test]
        public void AreaOfRectangle_WrongInputWidth_ReturnsOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfRectangle(9, -20));
        }

        [Test]
        public void AreaOfTriangle_ProperNumbers_ReturnsExpectedValue()
        {
            //Arrange
            var expected = 11.72;

            //Act
            var actual = Geometry.AreaOfTriangle((decimal)3.5, (decimal)6.7);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfTriangle_WrongInputGround_ReturnsOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfTriangle(-9, 20));
        }

        [Test]
        public void AreaOfTriangle_WrongInputHeight_ReturnsOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfTriangle(9, -20));
        }

    }
}