using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Insert(0, "Red");
            colors.Insert(0, "Green");
            colors.Insert(0, "Orange");
            colors.Insert(0, "White");
            colors.Insert(0, "Black");

            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0, "Cyan");
            colors.Insert(2, "Grey");

            Console.WriteLine(string.Join(",", colors));

            Console.Read();
        }
    }
}
