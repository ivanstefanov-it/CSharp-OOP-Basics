using System;
using System.Collections.Generic;

namespace TestClient
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<int, BankAccount> bank = new Dictionary<int, BankAccount>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputParts[0];

                switch (command)
                {
                    case "Create":
                        Create(bank, inputParts);
                        break;
                    case "Deposit":
                        Deposit(bank, inputParts);
                        break;
                    case "Withdraw":
                        Withdraw(bank, inputParts);
                        break;
                    case "Print":
                        Print(bank, inputParts);
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void Create(Dictionary<int, BankAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);

            if (bank.ContainsKey(id) == false)
            {
                BankAccount account = new BankAccount();
                account.Id = id;
                bank[id] = account;
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }

        private static void Deposit(Dictionary<int, BankAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            decimal amount = decimal.Parse(inputParts[2]);

            if (bank.ContainsKey(id))
            {
                bank[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(Dictionary<int, BankAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            decimal amount = decimal.Parse(inputParts[2]);

            if (bank.ContainsKey(id))
            {
                if (amount > bank[id].Balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    bank[id].Withdraw(amount);
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(Dictionary<int, BankAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);

            if (bank.ContainsKey(id))
            {
                Console.WriteLine($"Account ID{id}, balance {bank[id].Balance:F2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }
}
