using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            
            int sum = 0;

            foreach (var t in numbers)
            {
                sum += t;
            }

            double average = Math.Round((double)sum / numbers.Length, 2);
            Console.WriteLine("Average value of the array elements is : " + average);

            Console.ReadKey();
        }
    }
}
