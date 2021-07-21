using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms : ");

            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                i *= i;
            }
            
            Console.ReadKey();
        }
    }
}
