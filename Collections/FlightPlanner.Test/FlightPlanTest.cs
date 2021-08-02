using NUnit.Framework;
using System.Collections.Generic;

namespace FlightPlanner.Test
{
    public class Tests
    {
        [Test]
        public void AddFlights_DepartureAndArrival_ReturnsTrue()
        {
            //Arrange
            var expected = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Berlin", "Dubai")
            };

            //Act
            Flight.AddFlights("Berlin", "Dubai");
            var actual = Flight.FlightList;
            //Assert
            Assert.AreEqual(expected, actual);
        }





    }
}