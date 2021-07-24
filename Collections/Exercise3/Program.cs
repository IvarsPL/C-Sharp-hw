using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "_";
            var list = new List<string>();
            do
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                if (!list.Contains(name)) list.Add(name);

            } while (!string.IsNullOrEmpty(name));

            foreach (var person in list) { Console.WriteLine(person); }

            Console.Read();
        }
    }
}
