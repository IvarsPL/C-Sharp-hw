using System;

namespace Exercise_1
{
    public class Exercise1
    {

        public static bool CheckDigitsForFifteen(int one, int two)
        {
            if (
                one + two == 15 ||
                one - two == 15 ||
                two - one == 15 ||
                one == 15 ||
                two == 15)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first digit:");
            var firstDigit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Please enter second digit:");
            var secondDigit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine(CheckDigitsForFifteen(firstDigit, secondDigit));
        }
    }
}
