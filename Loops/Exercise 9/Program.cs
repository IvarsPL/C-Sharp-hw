using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            var desiredSum = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var diceSum = 0;

            do
            {
                Random r = new Random();
                int dieOne = r.Next(1, 6);
                int dieTwo = r.Next(1, 6);
                diceSum = dieOne + dieTwo;
                Console.WriteLine($"{dieOne} and {dieTwo} = {diceSum}");
            } while (desiredSum != diceSum);
        }
    }
}
