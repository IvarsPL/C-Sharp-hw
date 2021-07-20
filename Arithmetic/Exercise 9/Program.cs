using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight in kg");
            var weightInKg = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm");
            var heightInInches = int.Parse(Console.ReadLine()); ;

            var weight = weightInKg * 2.205;
            var height = heightInInches / 2.54;
            
            var bodyMassIndex = (weight * 703) / (height * height);
            var lowerOptimalIndex = 18.5;
            var higherOptimalIndex = 25;

            if (bodyMassIndex > lowerOptimalIndex && bodyMassIndex < higherOptimalIndex) Console.WriteLine("Your BMI is optimal");
            else if (bodyMassIndex > higherOptimalIndex) Console.WriteLine("You are overweight. Time to hit the gym");
            else  Console.WriteLine("You are underweight. Go get yourself some snacks.");
        }
    }
}
