using System;
using System.CodeDom;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (var i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

            foreach (var vowel in vowels)
            {
             Console.WriteLine(vowel);
            }

            Console.ReadKey();
        }
    }
}
