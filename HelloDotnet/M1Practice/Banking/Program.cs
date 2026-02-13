using System;
namespace HelloDotnet
{
    class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }
     public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw amount: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount or insufficient balance");
            }
        }
         public double GetBalance()
        {
            return balance;
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter transaction type (D for Deposit, W for Withdraw):");
                string type = Console.ReadLine()!;

                Console.WriteLine("Enter amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (type == "D")
                    account.Deposit(amount);
                else if (type == "W")
                    account.Withdraw(amount);
                else
                    Console.WriteLine("Invalid transaction type");
            }

            Console.WriteLine("Final Balance: " + account.GetBalance());
        }
    }
    
}