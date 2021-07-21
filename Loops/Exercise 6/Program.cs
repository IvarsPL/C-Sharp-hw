using System;

namespace Exercise_6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            var userInput = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < userInput; i++)
            {
                if (i % 20 == 0) Console.WriteLine($"{i} ");
                if (i % 15 == 0) Console.Write("FizzBuzz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else { Console.Write($"{i} "); }
            }

            Console.ReadKey();
        }
    }
}
