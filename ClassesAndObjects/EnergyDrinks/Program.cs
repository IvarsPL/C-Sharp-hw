using System;

namespace EnergyDrinks
{
    class Program
    {
        public const int NumberedSurveyed = 12467;
        public const double PurchasedEnergyDrinks = 0.14;
        public const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
           
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + CalculateEnergyDrinkers(NumberedSurveyed) + " bought at least one energy drink");
             Console.WriteLine(CalculatePreferCitrus(NumberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");

             Console.Read();

        }

        static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            return (int)Math.Round(numberSurveyed * PurchasedEnergyDrinks, 2);
        }

        static int CalculatePreferCitrus(int numberSurveyed)
        {
            return (int)Math.Round(CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks , 2);
        }
    }
}
