using NUnit.Framework;
using System;

namespace CalculateArea.Test
{
    public class Tests
    {
        [Test]
        public void AreaOfCircle_ProperNumbers_ReturnsTrue()
        {
            //Arrange
            var expected = 50.27;

            //Act
            var actual = Geometry.AreaOfCircle(4);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfCircle_ThrowsException_ReturnsTrue()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfCircle(-9));
        }

        [Test]
        public void AreaOfRectangle_ProperNumbers_ReturnsTrue()
        {
            //Arrange
            var expected = 35.88;

            //Act
            var actual = Geometry.AreaOfRectangle((decimal)4.6, (decimal)7.8);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfRectangle_ThrowsExceptionForLength_ReturnsTrue()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfRectangle(-9, 20));
        }

        [Test]
        public void AreaOfRectangle_ThrowsExceptionForWidth_ReturnsTrue()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfRectangle(9, -20));
        }

        [Test]
        public void AreaOfTriangle_ProperNumbers_ReturnsTrue()
        {
            //Arrange
            var expected = 11.72;

            //Act
            var actual = Geometry.AreaOfTriangle((decimal)3.5, (decimal)6.7);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfTriangle_ThrowsExceptionForGround_ReturnsTrue()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfTriangle(-9, 20));
        }

        [Test]
        public void AreaOfTriangle_ThrowsExceptionForHeight_ReturnsTrue()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Geometry.AreaOfTriangle(9, -20));
        }

    }
}