using System;

namespace Exercise_2
{
    public class Exercise2
    {
        public static string OddOrEven(int input)
        {
            return input % 2 == 0 ? "Even" : "Odd";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter odd or even number:");
            var userInput = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine(OddOrEven(userInput));
            Console.WriteLine("Bye!");

            Console.ReadKey();

        }
    }
}
