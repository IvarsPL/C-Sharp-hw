using System;
using System.Linq;

namespace CopyOfArrayExercise6
{
    public class ArrayExercise6Copy
    {
        public static int Min = 1;
        public static int Max = 100;

        public static Random RandNum = new Random();
        public static int[] FirstArray = Enumerable
            .Repeat(0, 10)
            .Select(i => RandNum.Next(Min, Max))
            .ToArray();

        public static int[] SecondArray = new int[FirstArray.Length];

        public static int[] MakeSecondArray(int[] first, int[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                second[i] = first[i];
            }

            return second;
        }

        static void Main()
        {
            MakeSecondArray(FirstArray, SecondArray);
            FirstArray[9] -= 7;

            Console.WriteLine(string.Join(',', FirstArray));
            Console.WriteLine(string.Join(',', SecondArray));

            Console.ReadKey();
        }
    }
}
