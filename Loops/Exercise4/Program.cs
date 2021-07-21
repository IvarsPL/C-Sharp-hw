using System;

namespace Exercise4
{
    internal class Program
    {
        //TODO: print all vowels using for and foreach
        private static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (var i = 0; i < vowels.Length; i++) Console.WriteLine(vowels[i]);

            foreach (var vowel in vowels) Console.WriteLine(vowel);

            Console.ReadKey();
        }
    }
}