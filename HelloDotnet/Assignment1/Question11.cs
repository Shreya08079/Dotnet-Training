using System;

namespace HelloDotnet.Assignment1
{
    class Question11
    {
        // This method checks whether the given date is valid or not
        public static void Run()
        {
            // Variables to store day, month and year
            int day;
            int month;
            int year;
            bool isValid = true;

            // Taking date input from user
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine()!);

            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine()!);

            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine()!);

            // Checking valid month
            if (month < 1 || month > 12)
            {
                isValid = false;
            }
            else
            {
                // Checking days based on month
                if (month == 2)
                {
                    // Checking leap year
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        if (day < 1 || day > 29)
                            isValid = false;
                    }
                    else
                    {
                        if (day < 1 || day > 28)
                            isValid = false;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day < 1 || day > 30)
                        isValid = false;
                }
                else
                {
                    if (day < 1 || day > 31)
                        isValid = false;
                }
            }

            // Printing the result
            if (isValid)
                Console.WriteLine("Entered date is valid");
            else
                Console.WriteLine("Entered date is not valid");
        }
    }
}
