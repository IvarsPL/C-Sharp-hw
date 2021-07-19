using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            var input1 = Int32.Parse(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            var input2 = Int32.Parse(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            var input3 = Int32.Parse(Console.ReadLine());

            var largestNumber = new List<int> { input1, input2, input3 }.Max();
            Console.WriteLine($"Largest number is {largestNumber}");

            Console.ReadKey();
        }
    }
}
