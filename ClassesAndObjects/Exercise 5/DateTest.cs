using System;

namespace Exercise_5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date today = new Date(23, 2021, 7);
            var print = today.DisplayDate();
            Console.WriteLine(print);

            Date randomDay = new Date(123, 20123, 14);
            print = randomDay.DisplayDate();
            Console.WriteLine(print);

            randomDay.Day = 30;
            randomDay.Month = 11;
            randomDay.Year = 0009;
            print = randomDay.DisplayDate();
            Console.WriteLine(print);

            Console.Read();
        }
    }
}
