using System;

namespace Exercise_10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Min?  ");
            var min = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Max?  ");
            var max = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            var numArray = new int[max - min + 1];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = min + i;
            }

            var startIndex = 0;

            foreach (var t in numArray)
            {
                for (int j = startIndex; j < numArray.Length + startIndex; j++)
                {
                    Console.Write(numArray[j % numArray.Length] + " ");
                }
                
                Console.WriteLine();
                startIndex++;
            }
        }
    }
}
