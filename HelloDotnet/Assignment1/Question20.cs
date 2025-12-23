using System;

namespace HelloDotnet.Assignment1
{
    class Question20
    {
        // This method finds the GCD and LCM of two numbers
        public static void Run()
        {
            // Variables to store numbers
            int num1;
            int num2;
            int gcd = 1;
            int lcm;

            // Taking input from user
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine()!);

            // Finding GCD using for loop
            for (int i = 1; i <= num1 && i <= num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                }
            }

            // Calculating LCM using formula
            lcm = (num1 * num2) / gcd;

            // Printing results
            Console.WriteLine("GCD is: " + gcd);
            Console.WriteLine("LCM is: " + lcm);
        }
    }
}
