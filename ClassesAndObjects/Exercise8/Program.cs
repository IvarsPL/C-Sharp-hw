using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("How much money is in the account? :");
           var balance = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

           Console.Write("Enter the annual interest rate :");
           var annualInterestRate = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

           Console.Write("How long has the account been opened? :");
           var monthsPassed = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

           SavingsAccount myAccount = new SavingsAccount(balance, annualInterestRate);

           double totalDeposit = 0;
           double totalWithdraw = 0;
           
           if (monthsPassed > 0)
           {
               for (int i = 1; i <= monthsPassed; i++)
               {
                   Console.Write($"Enter amount deposited for month {i}: ");
                   var deposit = double.Parse(Console.ReadLine());
                   myAccount.AddAmount(deposit);
                   totalDeposit += deposit;

                   Console.Write($"Enter amount withdrawn for month {i}: ");
                   var withdraw = double.Parse(Console.ReadLine());
                   myAccount.SubtractAmount(withdraw);
                   totalWithdraw -= withdraw;
                   
                   myAccount.AddInterestRate();
                   myAccount.CalculateTotalInterest();
                   
               }
               Console.WriteLine($"Total deposited: ${totalDeposit}");
               Console.WriteLine($"Total withdrawn: ${totalWithdraw}");
               Console.WriteLine($"Interest earned: ${myAccount.InterestEarned}");
               Console.WriteLine($"Ending balance: " + $"{myAccount.ShowBalance()}");
           }

           Console.ReadKey();
        }
    }
}
