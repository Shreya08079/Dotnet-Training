using System;
namespace HelloDotnet.Assignment1
{
    class Question8
    {
         // This method checks the type of triangle based on side lengths
        public static void Run()
        {
            // Input: lengths of the three sides of the triangle
            int side1;
            int side2;
            int side3;

            // Taking sides of triangle from user

            Console.WriteLine("Enter the lengths of the first side: ");
            side1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the lengths of the second side: ");
            side2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the lengths of the third side: ");
            side3 = int.Parse(Console.ReadLine()!);

            //checking the type of traingle
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }

        }
    }
}