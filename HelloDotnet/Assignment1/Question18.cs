using System;

namespace HelloDotnet.Assignment1
{
    class Question18
    {
        // This method checks whether a number is an Armstrong number or not
        public static void Run()
        {
            // Variables to store number and calculations
            int num;
            int originalNum;
            int digitCount = 0;
            int sum = 0;

            // Taking number from user
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine()!);

            originalNum = num;

            // Counting number of digits
            while (num != 0)
            {
                digitCount++;
                num = num / 10;
            }

            num = originalNum;

            // Calculating Armstrong sum
            while (num != 0)
            {
                int digit = num % 10;
                int power = 1;

                for (int i = 1; i <= digitCount; i++)
                {
                    power = power * digit;
                }

                sum = sum + power;
                num = num / 10;
            }

            // Checking Armstrong condition
            if (sum == originalNum)
                Console.WriteLine("The number is an Armstrong number");
            else
                Console.WriteLine("The number is not an Armstrong number");
        }
    }
}
