using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 1;
            int Max = 100;
            Random randNum = new Random();
            int[] firstArray = Enumerable
                .Repeat(0, 10)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            int[] secondArray = new int[firstArray.Length];

            for (var i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            firstArray[9] = -7;

            Console.WriteLine(string.Join(',', firstArray));
            Console.WriteLine(string.Join(',', secondArray));

            Console.ReadKey();
        }
    }
}
