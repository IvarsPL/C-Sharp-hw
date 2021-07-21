using System;

namespace Exercise_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first word:");
            var firstWord = Console.ReadLine();
            Console.WriteLine("Please enter the second word:");
            var secondWord = Console.ReadLine();

            var characterCounter = 30 - (firstWord.Length + secondWord.Length);

            Console.Write(firstWord);
            for (var i = 0; i < characterCounter; i++) Console.Write(".");
            Console.WriteLine(secondWord);

            Console.ReadKey();
        }
    }
}