using System;
namespace HelloDotnet.Assignment1
{
    class Question2
    {
        public static void Run()
        {
            int num1;
    Console.Write("Enter first num: ");
    num1 = int.Parse(Console.ReadLine()!);

    int num2;
    Console.Write("Enter second num: ");
    num2 = int.Parse(Console.ReadLine()!);

    int num3;
    Console.Write("Enter third num: ");
    num3 = int.Parse(Console.ReadLine()!);

    if (num1 >= num2 && num1 >= num3)
    {
        Console.WriteLine("Largest number is: " + num1);
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        Console.WriteLine("Largest number is: " + num2);
    }
    else
    {
        Console.WriteLine("Largest number is: " + num3);

    }

        }
    }
}