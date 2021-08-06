using NUnit.Framework;

namespace PhoneBook.Test
{
    public class Tests
    {
        [Test]
        public void PhoneEntryTest_CreateNewInstance_CreatesExpectedInstance()
        {
            //Arrange
            var expectedName = "Ivars";
            var expectedNumber = "26626878";
            //Act
            var actual = new PhoneEntry("Ivars", "26626878");
            //Assert
            Assert.AreEqual(expectedName, actual.name);
            Assert.AreEqual(expectedNumber, actual.number);
        }

        [Test]
        public void PhoneDirectoryTest_CreateNewInstance_ReturnsExpectedInstance()
        {
            //Arrange
            var expectedNumber = "26626878";
            //Act
            var directory = new PhoneDirectory();
            directory.PutNumber("Ivars", "26626878");
            //Assert
            Assert.AreEqual(expectedNumber, directory.GetNumber("Ivars"));

        }


    }
}