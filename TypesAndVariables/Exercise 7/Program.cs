using System;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        public static int ReturnCount(char[] input, ref int result)
       {
           foreach (var t in input)
           {
               if (char.IsUpper(t)) result ++;
           }
           return result;
       }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your text:");
            string input = Console.ReadLine();
            if (input != null)
            {
                char[] stringArray = input.ToCharArray();
                int result = 0;

               int finalCount = ReturnCount(stringArray,ref result);
               
                Console.WriteLine($"The amount of uppercase letters is {finalCount}");
            }

            Console.ReadKey();
        }
    }
}
