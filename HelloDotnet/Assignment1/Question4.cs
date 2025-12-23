using System;
namespace HelloDotnet.Assignment1
{
    class Question4
    {
        public static void Run()
        {
            double a;
Console.Write("Enter coefficient a: ");
a = double.Parse(Console.ReadLine()!);

double b;
Console.Write("Enter coefficient b: ");
b = double.Parse(Console.ReadLine()!);

double c;
Console.Write("Enter coefficient c: "); 
c = double.Parse(Console.ReadLine()!);

double d = b * b - 4 * a * c;
if (d > 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double root2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Roots are real and different.");
            Console.WriteLine("Root 1: " + root1);
            Console.WriteLine("Root 2: " + root2);
        }
        else if (d == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Roots are real and the same.");
            Console.WriteLine("Root: " + root);
        }
        else
        {
            Console.WriteLine("Roots are complex and different.");
        }


        }
    }
}