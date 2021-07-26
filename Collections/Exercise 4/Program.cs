using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Let's check if your number is happy.\n Enter a number: ");
            var input = (Console.ReadLine());
            var inputInt = Int32.Parse(input);
            List<int> intList = new List<int>();

            do
            {
                if (input.Length > 1)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        var newNum = inputInt % 10;
                        inputInt /= 10;
                        int newNumT = (int) Math.Pow(newNum, 2);
                        intList.Insert(0, newNumT);
                    }

                    if (inputInt == 0) inputInt = intList.Sum();
                }

                
            } while (inputInt>10);

            Console.WriteLine(inputInt == 1 ? "Your number is happy" : "Your number is not happy");


            Console.WriteLine(inputInt);
            Console.ReadKey();

           


        }
    }
}
