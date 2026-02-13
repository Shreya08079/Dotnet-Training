using System;

class InputHandler
{
    static void Main()
    {
        int number;

        while (true)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                number = int.Parse(Console.ReadLine()!);

                Console.WriteLine("You entered: " + number);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Program completed.");
    }
}
