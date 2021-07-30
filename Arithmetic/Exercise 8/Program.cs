using System;

namespace Exercise_8
{
    class Program
    {

        public static void EmployeePay(double pay, int hours)
        {
            var baseHour = 60;
            var basePay = 8.00;
            var normalHours = 40;
            double extraPayRate = 1.5;
            double salary;

            if (pay < basePay)
            {
                Console.WriteLine("Please double check the base pay.");
            }
            else if (hours > baseHour)
            {
                Console.WriteLine("You can't work that much.");
            }
            else if (hours > normalHours)
            {
                int extraHours = hours - normalHours;
                double extraPay = (pay * extraPayRate) * extraHours;
                salary = extraPay + (pay * normalHours);
                Console.WriteLine(salary);
            }
            else
            {
                salary = hours * pay;
                Console.WriteLine(salary);
            }
        }
        private static void Main()
        {
            EmployeePay(7.50, 35);
            EmployeePay(8.20, 47);
            EmployeePay(10.00, 73);

            Console.ReadKey();

        }
    }
}
