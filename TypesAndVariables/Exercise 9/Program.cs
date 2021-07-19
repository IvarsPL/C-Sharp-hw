using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data");
            Console.Write("Input distance in meters: ");
            int.TryParse(s: Console.ReadLine(), out var distance);
            Console.Write("Input hour: ");
            int.TryParse(s: Console.ReadLine(), out var hours);
            Console.Write("Input minutes: ");
            int.TryParse(s: Console.ReadLine(), out var minutes);
            Console.Write("Input seconds: ");
            int.TryParse(s: Console.ReadLine(), out var seconds);

            double mile = 1.60934f;
            double kilometer = 0.001f;

            double timeInSeconds = minutes * 60 + hours * 3600;
            double timeInHours = (minutes / 60) + (seconds / 3600) + hours;
            double metersPerSecond = distance / timeInSeconds;
            double kilometersPerHour = Math.Round ( (distance * kilometer) / timeInHours, 8);
            double milesPerHour = Math.Round(kilometersPerHour / mile, 8);

            Console.WriteLine("Expected output :");
            Console.WriteLine($"Your speed in meters/second is {metersPerSecond}");
            Console.WriteLine($"Your speed in km/h is {kilometersPerHour}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHour}");

            Console.ReadKey();
        }
    }
}
