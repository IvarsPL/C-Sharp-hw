using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your birth-year");
            int.TryParse(s: Console.ReadLine(), out int birthYear);
            Console.WriteLine($"My name is {name} and I was born in {birthYear}.");

            Console.ReadKey();
        }
    }
}
