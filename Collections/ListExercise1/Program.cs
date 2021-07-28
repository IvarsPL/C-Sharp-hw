using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>() { "1", "2", "3", "4", "5" };
            foreach (var element in colors) { Console.WriteLine(element); }

            colors.Add("Red");
            colors.Add("Cyan");
            colors.Add("Purple");
            colors.Add("Blue");
            colors.Add("Green");

            foreach (var element in colors) { Console.WriteLine(element); }

            Console.Read();
        }
    }
}
