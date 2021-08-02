using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class FlightPlan
    {
        static string _path = @"../../flights.txt";
        public static string[] ReadText = File.ReadAllLines(_path);
        public static string Delimiter = "->";
        public static List<string> FlightPath = new List<string>();
        public static List<string> Origins = new List<string>();

        public static void PrintFlightPath(List<string> flights)
        {
            for (int i = 0; i < flights.Count; i++)
            {
                if (i < flights.Count - 1)
                {
                    Console.Write($"{flights[i]} {Delimiter} ");
                }
                else
                {
                    Console.Write(flights[i]);
                }
            }
        }

        public static void CreateFlightPaths(string[] text)
        {
            foreach (var s in text)
            {
                var result = s.Split(new[] { Delimiter }, StringSplitOptions.None);
                Flight.AddFlights(result[0].Trim(), result[1].Trim());
                if (!Origins.Contains(result[0])) Origins.Add(result[0]);
            }
        }

        public static void DisplayDestinations(string chosenCity)
        {

            foreach (var city in Flight.FlightList)
            {
                if (chosenCity == city.Key) Console.WriteLine(city.Value);
            }
        }
        
        private static void Main(string[] args)
        {
            var chosenCity = "";
            CreateFlightPaths(ReadText);
            Flight.PrintFlights();
            PrintFlightPath(FlightPath);

            Console.Write("What would you like to do: \n To display list of the cities press 1 \n To exit program press #\n");
            var inputLine = Console.ReadLine();
            while (inputLine != "#")
            {
                while (inputLine == "1")
                {
                    foreach (var s in Origins) { Console.WriteLine(s); }
                    
                    Console.Write("Please enter the name of chosen city: ");
                    chosenCity = Console.ReadLine();
                    FlightPath.Add(chosenCity);

                    Console.WriteLine($"From {chosenCity} you can fly to:");
                    DisplayDestinations(chosenCity);

                    Console.Write("Enter your preferred destination: ");
                    chosenCity = Console.ReadLine();
                    FlightPath.Add(chosenCity);

                    Console.Write("To display list of the cities available from this destination press 2 \n To exit program and calculate flight path press #\n");
                    inputLine = Console.ReadLine();
                }

                while (inputLine == "2")
                {
                    Console.WriteLine($"The available destinations from {chosenCity} are:");
                    DisplayDestinations(chosenCity);

                    Console.Write("Please enter the name of chosen city: ");
                    chosenCity = Console.ReadLine();
                    FlightPath.Add(chosenCity);

                    Console.Write("To display list of the cities available press 2 \n To exit program press #\n");
                    inputLine = Console.ReadLine();
                }
            }

            PrintFlightPath(FlightPath);
            Console.WriteLine("\nHave a safe journey!");
            Console.ReadKey();
        }
    }
}
