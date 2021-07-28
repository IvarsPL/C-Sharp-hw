using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomList = new List<string>()
            {
                "Baby Yoda",
                "Baby Groot"
            };

            randomList.AddRange(new string[] {
                "IronMan", "Thor", "Loki", "Strange", "Hulk", "Wanda", "Vision", "Spider-man", "Hawk-eye", "Black Panther"});

            randomList.Insert(4, "Black Widow");
            randomList[randomList.Count - 1] = "Odin";
            randomList.Sort();
            randomList.Contains("Foobar");
            
            foreach (var hero in randomList) { Console.WriteLine(hero); }

            Console.Read();
        }
    }
}
