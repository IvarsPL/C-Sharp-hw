using System;
using System.Collections.Generic;

namespace FlightPlanner
{
    public class Flight
    {
        public static List<KeyValuePair<string, string>> FlightList = new List<KeyValuePair<string, string>>();

        public Flight()
        {
            FlightList = new List<KeyValuePair<string, string>>();
        }

        public static void AddFlights(string departure, string arrival)
        {
            FlightList.Add(new KeyValuePair<string, string>(departure, arrival));
        }

        public static void PrintFlights()
        {
            foreach (var flight in FlightList)
            {
                Console.WriteLine(flight);
            }
        }

    }
}
