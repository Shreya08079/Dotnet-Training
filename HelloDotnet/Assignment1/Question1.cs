using System;
namespace HelloDotnet.Assignment1
{
    // This class categorizes height input by the user
    class Question1
    {
        public static void Run()
        {
            // Variable to store height
            int height;

            // Taking height input from user 
            Console.Write("Enter height in cm: ");
            height = int.Parse(Console.ReadLine()!);

            // checking height using if-else-if 
        if (height < 150)
    {
        Console.WriteLine("Dwarf");
    }
    else if(height>=150 && height<=165)
    {
        Console.WriteLine("Average height");
    }
    else if(height>165 && height<=195)
    {
        Console.WriteLine("Tall");
    }
    else
    {
        Console.WriteLine("Abnormal height");
    }
        }
    }
}