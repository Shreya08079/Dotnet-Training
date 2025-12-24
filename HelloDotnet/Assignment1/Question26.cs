using System;

namespace HelloDotnet.Assignment1
{
    class Question26
    {
        // This method finds the digital root by repeatedly summing digits
        public static void Run()
        {
            // Variable to store number
            int num;
            int sum;

            // Taking input from user
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine()!);

            // Repeat until number becomes a single digit
            while (num >= 10)
            {
                sum = 0;

                // Summing digits of the number
                while (num > 0)
                {
                    sum = sum + (num % 10);
                    num = num / 10;
                }

                // Assign sum back to num
                num = sum;
            }

            // Printing final single digit result
            Console.WriteLine("Single digit result (Digital Root): " + num);
        }
    }
}
