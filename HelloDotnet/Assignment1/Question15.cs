using System;

namespace HelloDotnet.Assignment1
{
    class Question15
    {
        // This method performs a simple calculator operation based on user input
        public static void Run()
        {
            // Variables to store numbers and operator
            double num1;
            double num2;
            char op;

            // Taking numbers from user
            Console.Write("Enter first number: "); 
            num1 = double.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine()!);

            // Taking operator input from user
            Console.Write("Enter operator (+, -, *, /): ");
            op = char.Parse(Console.ReadLine()!);

            // Performing calculation using switch
            switch (op)
            {
                //Addition
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;


                //Subtraction
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;


                //Multiplication
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                
                //Division
                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operator entered");
                    break;
            }
        }
    }
}
