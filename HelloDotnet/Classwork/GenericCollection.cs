// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>();

//         numbers.Add(10);
//         numbers.Add(20);
//         numbers.Add(30);

//         foreach (int n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }
using System;

class Gen
{
    static void Print<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }

    public static void Run()
    {
        Print(100);
        Print("Generics in C#");
        Print(3.14);
    }
}
