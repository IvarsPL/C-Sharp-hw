using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter digits you wan to sum up:");
            string result = Console.ReadLine();
            var intList = result.Select(digit => int.Parse(digit.ToString()));

            int sum = intList.Sum();

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
