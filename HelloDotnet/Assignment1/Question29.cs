using System;

namespace HelloDotnet.Assignment1
{
    class Question29
    {
        // Strong number condition:
        // If sum of factorial of each digit is equal to the original number,
        // then the number is called a Strong number (example: 145 = 1! + 4! + 5!)
        public static void Run()
        {
            int num;
            int originalNum;
            int sum = 0;

            // Taking input from user
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine()!);

            originalNum = num;

            // Loop to extract each digit
            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;

                // Calculate factorial of the digit
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }

                // Add factorial value to sum
                sum = sum + fact;
                num = num / 10;
            }

            // Checking Strong number condition
            if (sum == originalNum)
            {
                Console.WriteLine("It is a Strong number");
            }
            else
            {
                Console.WriteLine("It is not a Strong number");
            }
        }
    }
}
