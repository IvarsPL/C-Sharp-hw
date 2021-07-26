using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Better\source\repos\C-Sharp-hw\Collections\WordCount\lear.txt");     
            Console.WriteLine(text);
            var wordCount = 0;
            int charCount = 0;
            int index = 0;
            var lineCount = File.ReadLines(@"C:\Users\Better\source\repos\C-Sharp-hw\Collections\WordCount\lear.txt").Count();
            
            foreach (var c in text)
            {
                charCount++;
            }

            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Chars = {charCount}");

            Console.Read();
        }
    }
}
