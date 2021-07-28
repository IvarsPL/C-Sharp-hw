using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string UserName;
        public double Balance;

        public BankAccount(string user, double balance)
        {
            this.UserName = user;
            this.Balance = Math.Round(balance,2);
        }

        public string ShowUserNameAndBalance()
        {
            if(Balance < 0) return $"{UserName} , -${Balance:0.00}";
            return $"{UserName} , ${Balance:0.00}";
        }
    }
}
