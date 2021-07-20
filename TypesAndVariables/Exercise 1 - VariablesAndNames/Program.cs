using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main()
        {
            int cars = 100;
            double seatsInACar = 4.0;
            int drivers = 28;
            int passengers = 90;
            int carsNotDriven = cars - drivers;
            int carsDriven = cars - carsNotDriven;
            double carpoolCapacity = carsDriven * seatsInACar;
            int averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put around " + averagePassengersPerCar + " in each car.");

            Console.ReadKey();
        }
    }
}