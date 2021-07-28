using System;

namespace Exercise_5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date today = new Date(23, 2021, 7);
            today.DisplayDate();
            Date randomDay = new Date(123, 20123, 14);
            randomDay.DisplayDate();
            randomDay.Day = 30;
            randomDay.Month = 11;
            randomDay.Year = 0009;
            randomDay.DisplayDate();

            Console.Read();
        }
    }
}
