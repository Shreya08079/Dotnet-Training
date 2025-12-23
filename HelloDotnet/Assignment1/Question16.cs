using System;

namespace HelloDotnet.Assignment1
{
    class Question16
    {
        // This method displays the Fibonacci series up to N terms
        public static void Run()
        {
            // Variable to store number of terms
            int n;

            // Taking input from user
            Console.Write("Enter number of terms: ");
            n = int.Parse(Console.ReadLine()!);

            // Initial values of Fibonacci series
            int first = 0;
            int second = 1;
            int next;

            Console.WriteLine("Fibonacci Series:");

            // Printing Fibonacci series
            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");

                next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
