using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomArray = new int[20];
            for (var i = 0; i < randomArray.Length; i++)
            {
                Random r = new Random();
                int randomNumber = r.Next(0, 100);
                randomArray[i] = randomNumber;
            }

            Console.WriteLine("Which index of random array you want to access?");
            var indexNumber = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"The number at your index is {randomArray[indexNumber]}");
             
            Console.ReadKey();
        }
    }
}
