using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IfScooters.Test
{
    public class ScooterRentTest
    {
        [Test] //Šeit nepadod ārā true, ka scooteris ir IsRented, bet gan izmet exceptionu, ka not found
        public void StartRent_RentANewScooter_ReturnsTrue()
        {
            //Arrange
            var s = new ScooterRent();
            var p = new ScooterService();
            
            //Act
            p.AddScooter("123", 2);
            var y = p.GetScooterById("123");
            s.StartRent("123");
            
            //Assert
            Assert.IsTrue(y.IsRented);
        }
    }
}
