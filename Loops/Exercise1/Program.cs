using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("The first 10 natural numbers are: ");

            for (var i = 1; i <= 10; i++) Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}