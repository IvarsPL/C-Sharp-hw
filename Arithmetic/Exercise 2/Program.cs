using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter odd or even number:");
            int oddOrEven = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine(oddOrEven % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine("Bye!");

            Console.ReadKey();

        }
    }
}
