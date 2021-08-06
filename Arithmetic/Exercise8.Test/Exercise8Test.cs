using NUnit.Framework;

namespace Exercise_8.Test
{
    public class Exercise8Test
    {
        [Test]
        public void EmployeePay_LessThanBasePay_ThrowsPayException()
        {
            //Arrange
            var pay = 7;
            var hours = 35;

            //Assert
            Assert.Throws<EmployeeException>(() => Exercise8.EmployeePay(pay, hours));
        }

        [Test]
        public void EmployeePay_TooManyHours_ReturnsThrowsHourException()
        {
            //Arrange
            var pay = 8.50;
            var hours = 61;

            //Assert
            Assert.Throws<EmployeeException>(() => Exercise8.EmployeePay(pay, hours));
        }

        [Test]
        public void EmployeePay_ExtraHours_ReturnsCorrectExtraHourPay()
        {
            //Arrange
            var pay = 8;
            var hours = 41;
            var equals = 332;
            //Act
            var actual = Exercise8.EmployeePay(pay, hours);
            //Assert
            Assert.AreEqual(equals, actual);
        }

        [Test]
        public void EmployeePay_NormalPay_ReturnsCorrectPay()
        {
            //Arrange
            var pay = 8;
            var hours = 40;
            var equals = 320;
            //Act
            var actual = Exercise8.EmployeePay(pay, hours);
            //Assert
            Assert.AreEqual(equals, actual);
        }
    }
}