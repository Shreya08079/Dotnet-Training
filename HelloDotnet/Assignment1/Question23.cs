using System;

namespace HelloDotnet.Assignment1
{
    class Question23
    {
        // This method prints a diamond pattern using * symbols
        public static void Run()
        {
            // Variable to store number of rows
            int n;

            // Taking number of rows from user
            Console.Write("Enter number of rows: ");
            n = int.Parse(Console.ReadLine()!);

            // Printing upper half of diamond
            for (int i = 1; i <= n; i++)
            {
                // Printing spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Printing stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Printing lower half of diamond
            for (int i = n - 1; i >= 1; i--)
            {
                // Printing spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Printing stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
