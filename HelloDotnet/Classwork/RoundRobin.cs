using System;

class Robin
{
    public static void Run()
    {
        int a = int.MaxValue;  // maximum value an int can hold: 2147483647
        // int b = unchecked(a + 1); // allows overflow wrap-around
        int b = a + 1; // causes overflow exception in checked context
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b); // wraps around to int.MinValue
    }
}
