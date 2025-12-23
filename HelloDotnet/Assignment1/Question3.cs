using System;
namespace HelloDotnet.Assignment1
{
    class Question3
    {
        public static void Run()
        {
            int number;
Console.Write("Enter year: ");
number = int.Parse(Console.ReadLine()!);
if ((number % 4 == 0 && number % 100 != 0) || (number % 400 == 0))
        {
            Console.WriteLine("{0} is a leap year.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", number);
        }


        }
    }
}