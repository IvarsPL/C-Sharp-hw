using System;

namespace Exercise_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var randomArray = new int[20];
            for (var i = 0; i < randomArray.Length; i++)
            {
                var r = new Random();
                var randomNumber = r.Next(0, 100);
                randomArray[i] = randomNumber;
            }

            Console.WriteLine("Which index of random array you want to access?");
            var indexNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number at your index is {randomArray[indexNumber]}");

            Console.ReadKey();
        }
    }
}