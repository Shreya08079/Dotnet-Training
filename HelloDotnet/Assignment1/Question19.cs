using System;

namespace HelloDotnet.Assignment1
{
    class Question19
    {
        // This method reverses a number and checks whether it is a palindrome
        public static void Run()
        {
            // Variables to store number and reverse
            int num;
            int originalNum;
            int reverse = 0;

            // Taking number from user
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine()!);

            originalNum = num;

            // Reversing the number using while loop
            while (num != 0)
            {
                int digit = num % 10;
                reverse = (reverse * 10) + digit;
                num = num / 10;
            }

            // Printing reversed number
            Console.WriteLine("Reversed number is: " + reverse);

            // Checking palindrome condition
            if (reverse == originalNum)
                Console.WriteLine("The number is a Palindrome");
            else
                Console.WriteLine("The number is not a Palindrome");
        }
    }
}
