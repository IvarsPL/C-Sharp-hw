using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise8
{
    class SavingsAccount
    {
        private double _annualInterestRate;
        public double MonthlyInterestRate;
        public double Balance;
        public double InterestEarned;

        public SavingsAccount(double balance, double annualInterestRate)
        {
            this.Balance = balance;
            _annualInterestRate = annualInterestRate;
            this.InterestEarned = 0;
            this.MonthlyInterestRate = (annualInterestRate / 12)/100;
        }

        public void SubtractAmount(double amount)
        {
            Balance -= amount;
        }

        public void AddAmount(double amount)
        {
            Balance += amount;
        }

        public void AddInterestRate()
        {
            Balance += MonthlyInterestRate * Balance;
        }

        public void CalculateTotalInterest()
        {
            InterestEarned += MonthlyInterestRate * Balance;
        }

        public double ShowBalance()
        {
            return Balance;
        }
    }
}
