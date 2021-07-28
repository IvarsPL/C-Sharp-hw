using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };
            var list = new List<string>();
            var set = new HashSet<string>();
            var dictionary = new Dictionary<string, string>();

            foreach (var car in array) { list.Add(car); }
            foreach (var car in list) { Console.WriteLine(car); }

            foreach (var car in array) { set.Add(car); }
            foreach (var car in set) { Console.WriteLine(car); }

            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("Volkswagen", "Germany");
            dictionary.Add("Tesla", "USA");

            foreach (var car in dictionary) { Console.WriteLine(car); }

            Console.Read();
        }
    }
}
