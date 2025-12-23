using System;

namespace HelloDotnet.Assignment1
{
    class Question24
    {
        // This method calculates factorial and checks for overflow
        public static void Run()
        {
            // Variables to store number and factorial
            int n;
            long factorial = 1;
            bool overflow = false;

            // Taking number from user
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine()!);

            // Calculating factorial using for loop
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    factorial = checked(factorial * i);
                }
                catch (OverflowException)
                {
                    overflow = true;
                    break;
                }
            }

            // Printing result
            if (overflow)
            {
                Console.WriteLine("Factorial result is too large to store");
            }
            else
            {
                Console.WriteLine("Factorial is: " + factorial);
            }
        }
    }
}
