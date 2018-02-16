using System;

namespace _02.BankAccountMethods
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 200;

            acc.Deposit(800);
            Console.WriteLine($"{acc.Id} {acc.Balance}");

            acc.Withdraw(250);
            Console.WriteLine($"{acc.Id} {acc.Balance}");

        }
    }
}
