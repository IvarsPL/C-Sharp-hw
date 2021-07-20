using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            Random random = new Random();
            int myNumber = random.Next(1, 100);
            int guessedNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (guessedNumber > myNumber) Console.WriteLine($"Sorry, you are too high. I was thinking of {myNumber}");
            else if (guessedNumber < myNumber) Console.WriteLine($"Sorry, you are too low. I was thinking of {myNumber}");
            else if (guessedNumber == myNumber) Console.WriteLine("You guessed it! What are the odds?!?");

            Console.ReadKey();
        }
    }
}
