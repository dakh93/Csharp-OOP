using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TestClient
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                .Split(' ')
                .ToArray();

            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            while (input.Length > 1)
            {


                var command = input[0];

                switch (command)
                {
                    case "Create":
                        Create(input, accounts);
                        break;
                    case "Deposit":
                        Deposit(input, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(input, accounts);
                        break;
                    case "Print":
                        Print(input, accounts);
                        break;
                }



                input =
                    Console.ReadLine()
                        .Split(' ')
                        .ToArray();
            }
        }

        private static void Print(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int acc = int.Parse(input[1]);

            if (accounts.ContainsKey(acc))
            {
                Console.WriteLine($"Account ID{acc}, balance {accounts[acc].Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int acc = int.Parse(input[1]);
            decimal withdraw = decimal.Parse(input[2]);

            if (accounts.ContainsKey(acc))
            {
                if (accounts[acc].Balance >= withdraw)
                {
                    accounts[acc].Balance -= withdraw;
                    
                }
                else if(accounts[acc].Balance < withdraw)
                {
                    Console.WriteLine($"Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int acc = int.Parse(input[1]);
            decimal deposit = decimal.Parse(input[2]);

            if (accounts.ContainsKey(acc))
            {
                accounts[acc].Balance += deposit;
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int acc = int.Parse(input[1]);
            if (accounts.ContainsKey(acc))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                accounts.Add(acc, new BankAccount());
            }
        }
    }
}
