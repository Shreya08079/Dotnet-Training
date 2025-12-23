using System;

namespace HelloDotnet.Classwork
{
    class Student
    {
        static int age;
        static string name = "";

        public static void Details()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine()!;

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine()!);
        }

        public static void Print()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
