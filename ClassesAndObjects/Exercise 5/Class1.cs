using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5
{
    class Date
    {
        private int _month;
        public int Month
        {
            get => _month;
            set
            {
                if (value > 0 && value < 13) _month = value;
                else {Console.WriteLine("Invalid month input");}
            }
        }

        private int _day;
        public int Day
        {
            get => _day;
            set
            {
                if (value > 0 && value < 31) _day = value;
                else { Console.WriteLine("Invalid day input"); }
            }
        }

        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (value > 0 && value < 10000) _year = value;
                else { Console.WriteLine("Invalid year input"); }
            }
        }

        public Date(int day, int year, int month)
        {
            this.Month = month;
            this.Year = year;
            this.Day = day;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{_month :00}/{_day :00}/{_year :0000}");
        }
    }
}
