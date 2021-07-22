using System;
using System.Globalization;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            
            var input = Console.ReadLine();
            var numberToCheck = long.Parse(input ?? throw new InvalidOperationException());
            
                if (input.Length <= 10) 
                {
                    if (numberToCheck < 0) 
                    {
                        numberToCheck *= -1;
                    }

                    if (numberToCheck >= 10000000000)
                    {
                        Console.WriteLine("Number is greater or equals 10,000,000,000!");
                    } 
                    else
                    {
                        var digits = 0;

                        switch (input.Length)
                        {
                        case 1: 
                            digits = 1;
                            break;
                        case 2: 
                            digits = 2;
                            break;
                        case 3: 
                            digits = 3;
                            break;
                        case 4: 
                            digits = 4;
                            break;
                        case 5:
                            digits = 5;
                            break;
                        case 6:
                            digits = 6;
                            break;
                        case 7:
                            digits = 7;
                            break;
                        case 8:
                            digits = 8;
                            break;
                        case 9:
                            digits = 9;
                            break;
                        case 10:
                            digits = 10;
                            break;
                        default: Console.WriteLine("oops");
                            break;
                        }
                     

                    Console.WriteLine("Number of digits in the number: " + digits);
                    }
                } 
                else 
                {
                    Console.WriteLine("The number is not a long");
                }

                Console.ReadKey();
        }
            
    }
          
}
