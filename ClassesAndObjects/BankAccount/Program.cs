using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benBen = new BankAccount("Benson", 17.25);
            Console.Write(benBen.ShowUserNameAndBalance());
            Console.Read();
        }
    }
}
