using System;

namespace HelloDotnet.Assignment1
{
    class Question12
    {
        // This method simulates an ATM withdrawal process using nested if
        public static void Run()
        {
            //variable declaration
            int balance = 100000;   // Assuming initial account balance
            int withdrawAmount;
            char cardInserted;
            int pin;

            // Checking if card is inserted
            Console.Write("Is card inserted? (y/n): ");
            cardInserted = char.Parse(Console.ReadLine()!);

            if (cardInserted == 'y' || cardInserted == 'Y')
            {
                // Asking for PIN
                Console.Write("Enter PIN: ");
                pin = int.Parse(Console.ReadLine()!);

                if (pin == 0809)   // Assuming 0809 as correct PIN
                {
                    // Asking for withdrawal amount
                    Console.Write("Enter withdrawal amount: ");
                    withdrawAmount = int.Parse(Console.ReadLine()!);

                    if (withdrawAmount <= balance)
                    {
                        Console.WriteLine("Please collect your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid PIN");
                }
            }
            else
            {
                Console.WriteLine("Please insert your card");
            }
        }
    }
}
