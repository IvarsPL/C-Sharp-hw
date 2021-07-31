using System;

namespace Exercise_8
{
    public class Exercise8
    {
        public static double EmployeePay(double pay, int hours)
        {
            var baseHour = 60;
            var basePay = 8.00;
            var normalHours = 40;
            double extraPayRate = 1.5;
            double salary;

            if (pay < basePay)
            {
                throw new EmployeeException("Please double check the base pay.");
            }
            if (hours > baseHour)
            {
                throw new EmployeeException("You can't work that much.");
            }
            if (hours > normalHours)
            {
                int extraHours = hours - normalHours;
                double extraPay = (pay * extraPayRate) * extraHours;
                salary = extraPay + (pay * normalHours);
                return salary;
            }

            salary = hours * pay;
            return salary;
        }
        private static void Main()
        {
            try
            {
                Console.WriteLine(EmployeePay(7.50, 35));
                Console.WriteLine(EmployeePay(8.20, 47));
                Console.WriteLine(EmployeePay(10.00, 73));
            }
            catch (EmployeeException e)
            {
                Console.WriteLine(e);
            }


            Console.ReadKey();

        }
    }
}
