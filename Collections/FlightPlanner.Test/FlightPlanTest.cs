using System.Collections.Generic;
using NUnit.Framework;

namespace FlightPlanner.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void FlightConstructor_CreatesEmptyKeyValueList_ReturnsTrue()
        {
            //Arrange
            var expected = new List<KeyValuePair<string, string>>();
            
            

            //Assert
            Assert.AreEqual(expected, Flight.FlightList);
        }

       

       
    }
}