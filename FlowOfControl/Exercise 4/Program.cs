using System;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter day number:");
            var dayNumber = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            
            switch (dayNumber)
            {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:Console.WriteLine("Not a valid day");
                        break;
            }
            
            Console.ReadKey();
        }
    }
}
