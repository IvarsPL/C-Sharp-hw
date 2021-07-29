using System;
using Xunit;
using CopyOfArrayExercise6;

namespace ArrayExercise6.Test
{
    public class ArrayExercise6Test
    {
        [Fact]
        public void MakeSecondArray_ShouldReturnSecondArray()
        {
            // Arrange
            int[] firstArray = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] secondArray = new int[10];

            // Act
            int[] actual = ArrayExercise6Copy.MakeSecondArray(firstArray, secondArray);
            // Assert
            Assert.Equal(expected,actual);
        }
    }
}
