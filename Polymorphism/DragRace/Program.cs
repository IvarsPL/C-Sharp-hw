using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {

        private static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>();
            var porche = new Porche();
            var mercedes = new Mercedes();
            var tesla = new Tesla();
            var lexus = new Lexus();
            var bmw = new Bmw();
            var audi = new Audi();

            cars.Add(porche);
            cars.Add(mercedes);
            cars.Add(tesla);
            cars.Add(lexus);
            cars.Add(bmw);
            cars.Add(audi);

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();
                    if (i != 2 || car is not INitrousCar) continue;
                    var nitros = car as INitrousCar;
                    nitros.UseNitrousOxideEngine();
                }
            }

            int maxSpeed = cars.Max(t => Int32.Parse(t.ShowCurrentSpeed()));
            foreach (var car in cars)
            {
                if (Int32.Parse(car.ShowCurrentSpeed()) == maxSpeed) Console.WriteLine($"Fastest car was : {car.Name}");
            }
            Console.WriteLine($"Fastest speed was {maxSpeed} km/h");

            Console.Read();
        }
    }
}