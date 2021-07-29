using System;
using System.Linq;

namespace Exercise_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            Random randNum = new Random();
            int[] firstArray = Enumerable
                .Repeat(0, 10)
                .Select(i => randNum.Next(min, max))
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
