using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first digit:");
            var firstDigit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Please enter second digit:");
            var secondDigit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (
                firstDigit + secondDigit == 15 ||
                firstDigit - secondDigit == 15 || 
                secondDigit - firstDigit == 15 || 
                firstDigit == 15 || 
                secondDigit == 15 
                ) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
