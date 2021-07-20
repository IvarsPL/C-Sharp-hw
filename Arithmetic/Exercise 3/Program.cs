using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            double average = Math.Round((double)sum / 100, 1);

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");

            Console.ReadKey();
        }
    }
}
