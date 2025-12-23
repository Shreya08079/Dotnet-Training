using System;

namespace HelloDotnet.Assignment1
{
    class Question21
    {
        // This method prints Pascal's Triangle up to N rows
        public static void Run()
        {
            // Variable to store number of rows
            int n;

            // Taking number of rows from user
            Console.Write("Enter number of rows: ");
            n = int.Parse(Console.ReadLine()!);

            // Printing Pascal's Triangle using nested loops
            for (int i = 0; i < n; i++)
            {
                int number = 1;

                // Printing spaces for triangle shape
                for (int space = 0; space < n - i; space++)
                {
                    Console.Write(" ");
                }

                // Printing values in each row
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number = number * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
