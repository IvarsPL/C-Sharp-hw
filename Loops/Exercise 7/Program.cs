using System;

namespace Exercise_7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            string[] diceArray = new string[] { "one", "two", "three", "four", "five", "six" };
            int[] diceValueArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int randomRoll;
            Random r = new Random();
            int gameOver = 0;
            int pointSum = 0;
            var userInput = "y";

            Console.WriteLine("Welcome to Piglet!");
            do
            {
                randomRoll = r.Next(0, diceArray.Length);
                if (randomRoll != 0)
                {
                    Console.Write($"You rolled a {diceArray[randomRoll]}! \n Roll again? (y/n): ");
                    pointSum += diceValueArray[randomRoll];
                    userInput = Console.ReadLine();
                }
                else
                {
                    userInput = "n";
                    Console.WriteLine("You rolled a 1!");
                }

            } while (randomRoll != gameOver && userInput != "n");
            Console.WriteLine($"You got {pointSum} points.");

        }
    }
}
