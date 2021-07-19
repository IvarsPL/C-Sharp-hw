using System;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter minutes that need to be calculated:");
            int.TryParse(s: Console.ReadLine(), out int minutes);
           
            int minutesInAYear = 525600;
            int minutesInADay = 1440;

            int years = minutes / minutesInAYear;
            int days = (minutes % minutesInAYear) / minutesInADay;
            Console.WriteLine($"It will be {years} year/-s and {days} day/-s.");

            Console.ReadKey();
        }
    }
}
