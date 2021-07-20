using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main()
        {
            double inchToCm = 2.54;
            double poundToKg = 0.453592;
            double height = Math.Round(74 * inchToCm, 2);
            double weight = Math.Round(180 * poundToKg, 2);
            int age = 35;

            string name = "Zed A. Shaw";
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {height} cm tall.");
            Console.WriteLine($"He's {weight} kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyes} eyes and {hair} hair.");
            Console.WriteLine($"His teeth are usually {teeth} depending on the coffee.");
            Console.WriteLine($"If I add {age}, {height}, and {weight} I get {(age + height + weight)}.");

            Console.ReadKey();
        }
    }
}