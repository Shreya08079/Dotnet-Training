using System;

namespace HelloDotnet.Assignment1
{
    class Question17
    {
        // This method checks whether a number is prime or not
        public static void Run()
        {
            // Variable to store number
            int num;
            bool isPrime = true;

            // Taking number from user
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine()!);

            // Checking prime using for loop
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;   // Number is not prime, exit loop
                    }
                }
            }

            // Printing result
            if (isPrime)
                Console.WriteLine("The number is Prime");
            else
                Console.WriteLine("The number is Not Prime");
        }
    }
}
