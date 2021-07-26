using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace FlightPlanner
{
    class Program
    {
        static string path = @"C:\Users\Better\Desktop\flights.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(path);
            var flights = new List<KeyValuePair<string, string>>();
            var delimiter = "->";
            var origins = new List<string>();
            var flightPath = new List<string>();
            var chosenCity = "";

            foreach (var s in readText)
            {
                var result = s.Split(new[] { delimiter }, StringSplitOptions.None);
                flights.Add(new KeyValuePair<string, string>(result[0].Trim(), result[1].Trim()));
                if (!origins.Contains(result[0])) origins.Add(result[0]);
            }

            Console.Write("What would you like to do: \n To display list of the cities press 1 \n To exit program press #\n");
            var inputLine = Console.ReadLine();
            while (inputLine != "#")
            {
                while (inputLine == "1")
                {
                    foreach (var s in origins) { Console.WriteLine(s); }
                    Console.Write("Please enter the name of chosen city: ");
                    chosenCity = Console.ReadLine();
                    flightPath.Add(chosenCity);
                    Console.WriteLine($"From {chosenCity} you can fly to:");

                    foreach (var city in flights)
                    {
                        if (chosenCity == city.Key) Console.WriteLine(city.Value);
                    }

                    Console.Write("Enter your preferred destination: ");
                    chosenCity = Console.ReadLine();
                    flightPath.Add(chosenCity);
                    Console.Write("To display list of the cities available from this destination press 2 \n To exit program and calculate flight path press #\n");
                    inputLine = Console.ReadLine();
                }

                while (inputLine == "2")
                {
                    Console.WriteLine($"The available destinations from {chosenCity} are:");
                    foreach (var city in flights)
                    {
                        if (chosenCity == city.Key) Console.WriteLine(city.Value);
                    }
                    Console.Write("Please enter the name of chosen city: ");
                    chosenCity = Console.ReadLine();
                    flightPath.Add(chosenCity);
                    
                    Console.Write("To display list of the cities available press 2 \n To exit program press #\n");
                    inputLine = Console.ReadLine();
                }
            }

            for (int i = 0; i < flightPath.Count; i++)
            {
                if (i < flightPath.Count -1)
                {
                    Console.Write($"{flightPath[i]} {delimiter} ");
                }
                else
                {
                    Console.Write(flightPath[i]);
                }
            }
            Console.WriteLine("Have a safe journey!");
            Console.ReadKey();
        }
    }
}
