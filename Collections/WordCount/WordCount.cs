using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        public static int CharCounter(string text)
        {
            var charCount = 0;
            foreach (var c in text)
            {
                if (Char.IsLetterOrDigit(c)) charCount++;
            }

            return charCount;
        }

        public static int WordCouner(string text)
        {
            var wordCount = 0;
            var index = 0;

            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            return wordCount;
        }

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Better\source\repos\C-Sharp-hw\Collections\WordCount\lear.txt");
            var wordCount = WordCouner(text);
            int charCount = CharCounter(text);
            var lineCount = File.ReadLines(@"C:\Users\Better\source\repos\C-Sharp-hw\Collections\WordCount\lear.txt").Count();

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Chars = {charCount}");

            Console.Read();
        }
    }
}
