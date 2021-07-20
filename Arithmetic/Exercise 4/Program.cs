using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
            var factorialFrom = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var returnFactorial = 1;

            for (int i = 1; i <= factorialFrom; i++)
            {
                returnFactorial = returnFactorial * i;
            }

            Console.WriteLine(returnFactorial);


            Console.ReadKey();
        }
    }
}
