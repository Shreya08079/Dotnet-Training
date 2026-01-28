using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("How many numbers?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        var evenNum = numbers.Where(x => x % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNum)
        {
            Console.WriteLine(num);
        }
    }
}
