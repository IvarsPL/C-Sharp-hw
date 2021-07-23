using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter first reading: ");
                car.StartKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                car.Liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(car.StartKilometers, car.Liters);

                Console.Write("Enter first reading: ");
                car1.StartKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                car1.Liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(car1.StartKilometers, car1.Liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
