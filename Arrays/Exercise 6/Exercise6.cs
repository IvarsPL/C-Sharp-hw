using System;
using System.Linq;

namespace Exercise_6
{
    public class Exercise6
    {
       
        public static int[] FirstArray = new int[10];
        
        public static int[] SecondArray = new int[FirstArray.Length];
        public static int[] MakeRandomArray()
        {
        Random RandNum = new Random();
        var first = Enumerable
            .Repeat(0, 10)
            .Select(i => RandNum.Next(1, 100))
            .ToArray();
        return first;
        }

        public static int[] MakeSecondArray(int[] first, int[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                second[i] = first[i];
            }

            return second;
        }

        public static void ChangeLastDigit(int[] first)
        {
            first[9] = -7;
        }

        static void Main()
        {
            FirstArray = MakeRandomArray();
            MakeSecondArray(FirstArray, SecondArray);
            ChangeLastDigit(FirstArray);

            Console.WriteLine(string.Join(',', FirstArray));
            Console.WriteLine(string.Join(',', SecondArray));

            Console.ReadKey();
        }
    }
}
