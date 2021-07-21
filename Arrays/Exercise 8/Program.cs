using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var endGame = false;
            var turnCounter = 10;
            var missedChars = new char[10];
            var missedCharsIndex = 0;

            var randomWords = new List<string>{ "LEVIATHAN", "YOUNG", "FEW", "APOLOGY", "PUDDING"};
            Random selectWord = new Random();
            char[] chosenWord = randomWords[selectWord.Next(0, randomWords.Count)].ToCharArray();
            char[] hiddenWord = new char[chosenWord.Length];

            for (int i = 0; i < chosenWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }

            while (endGame == false)
            {
              Console.Write($"Word:   {string.Join(' ',hiddenWord)}\n");
              Console.Write($"Misses:   {string.Join(' ', missedChars)}\n");
              Console.Write("Guess:  ");
                
              char.TryParse(Console.ReadLine(), out var guess);
              guess = Char.ToUpper(guess);
              
              if (!missedChars.Contains(guess))
              {
                  for (int i = 0; i < hiddenWord.Length; i++)
                  {
                      if (guess == chosenWord[i])
                      {
                          hiddenWord[i] = guess;
                      }
                  }
              }

              else if (!chosenWord.Contains(guess))
              {
                  missedChars[missedCharsIndex] = guess;
                  turnCounter--;
                  missedCharsIndex++;
              }
              
              if (!hiddenWord.Contains('_'))
              {
                    endGame = true;
                    Console.WriteLine("YOU GOT IT!");
              }

              if (turnCounter == 0)
              {
                  endGame = true;
                  Console.WriteLine("SORRY. BETTER LUCK NEXT TIME!");
              }

              Console.WriteLine("_________________________\n");
            }

            Console.ReadKey();
        }
    }
}
