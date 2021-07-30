using System;
using NUnit.Framework;
using Exercise_6;
using Microsoft.VisualBasic;


namespace Exercise6.Test
{
    [TestFixture]
    public class Exercise6Test
    {
        [Test]
        public void MakeSecondArray_ShouldReturnSecondArrayEqualToFirst()
        {
            // Arrange
            int[] firstArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = new int[10];

            // Act
            int[] actual = Exercise_6.Exercise6.MakeSecondArray(firstArray, secondArray);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeLastDigit_RandomDigitArray_ShouldBeMinusSeven()
        {
            //Arrange
            int[] firstArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = -7;

            //Act
            Exercise_6.Exercise6.ChangeLastDigit(firstArray);
            var actual = firstArray[9];

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void MakeRandomArray_RandomArray_NotEqual()
        {
            //Arrange
            int[] caseOne = new int[10];
            int[] caseTwo = new int[10];
            Random RandNum = new Random();

            ////Act
            caseOne = Exercise_6.Exercise6.MakeRandomArray();
            caseTwo = Exercise_6.Exercise6.MakeRandomArray();

            //Assert
            for (var i = 0; i < caseTwo.Length; i++)
            {
                Assert.AreNotEqual(caseOne[i], caseTwo[i]);
            }
        }
    }
}