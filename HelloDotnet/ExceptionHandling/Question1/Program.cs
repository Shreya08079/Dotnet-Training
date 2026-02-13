using System;

public class BankAccount
{
    public static void Main(string[] args)
    {
        int balance = 10000;

        Console.WriteLine("Enter withdrawal amount:");
        int amount = int.Parse(Console.ReadLine()!);

        try
        {
            
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

           
            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance: " + balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
           
            Console.WriteLine("Transaction attempt completed.");
        }
    }
}
