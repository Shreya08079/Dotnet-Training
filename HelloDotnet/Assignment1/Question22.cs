using System;

namespace HelloDotnet.Assignment1
{
    class Question22
    {
        // This method converts a binary number to decimal
        public static void Run()
        {
            // Variables to store binary input and decimal result
            string binary;
            int decimalNumber = 0;
            int baseValue = 1;

            // Taking binary number from user
            Console.Write("Enter a binary number: ");
            binary = Console.ReadLine()!;

            // Converting binary to decimal using while loop
            int i = binary.Length - 1;

            while (i >= 0)
            {
                if (binary[i] == '1')
                {
                    decimalNumber = decimalNumber + baseValue;
                }

                baseValue = baseValue * 2;
                i--;
            }

            // Printing decimal value
            Console.WriteLine("Decimal value is: " + decimalNumber);
        }
    }
}
