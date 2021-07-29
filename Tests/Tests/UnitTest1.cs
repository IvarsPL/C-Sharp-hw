using CopyOfArrayExercise6;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MakeSecondArray_WithSimpleNumbers_ReturnsTrue()
        {
            //Arrange
            var expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var result = new int[expected.Length];
            //Act
            result = ArrayExercise6Copy.MakeSecondArray(expected,result);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}