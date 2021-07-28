using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string _path = @"C:\Users\Better\source\repos\C-Sharp-hw\Collections\Histogram\midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(_path);
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, ninth = 0, tenth = 0;
            var input = new List<string>();
            
            foreach (var s in readText)
            {
                input = s.Split().ToList();
            }

            foreach (var grade in input)
            {
                switch (Int32.Parse(grade))
                {
                    case int n when (n <= 9 && n > 0):
                        first++;
                        break;
                    case int n when (n <= 19 && n > 9):
                        second++;
                        break;
                    case int n when (n <= 29 && n > 19):
                        third++;
                        break;
                    case int n when (n <= 39 && n > 19):
                        fourth++;
                        break;
                    case int n when (n <= 49 && n > 19):
                        fifth++;
                        break;
                    case int n when (n <= 59 && n > 19):
                        sixth++;
                        break;
                    case int n when (n <= 69 && n > 19):
                        seventh++;
                        break;
                    case int n when (n <= 79 && n > 19):
                        eighth++;
                        break;
                    case int n when (n <= 89 && n > 19):
                        ninth++;
                        break;
                    case int n when (n <= 89 && n > 19):
                        ninth++;
                        break;
                    case int n when (n == 100):
                        tenth++;
                        break;
                }
            }

            var catalog = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>( "00-09:", first),
                new KeyValuePair<string, int>("10-19:", second),
                new KeyValuePair<string, int>("20-29:", third),
                new KeyValuePair<string, int>("30-39:", fourth),
                new KeyValuePair<string, int>("40-49:", fifth),
                new KeyValuePair<string, int>("60-69:", sixth),
                new KeyValuePair<string, int>("70-79:", seventh),
                new KeyValuePair<string, int>("80-89:", eighth),
                new KeyValuePair<string, int>("90-99:", ninth),
                new KeyValuePair<string, int>("  100:", tenth)
            };

            foreach (var gradeRange in catalog)
            {
                Console.Write(gradeRange.Key);
                for (int i = 0; i < gradeRange.Value; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

