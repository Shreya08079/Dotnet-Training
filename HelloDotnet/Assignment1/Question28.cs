using System;

namespace HelloDotnet.Assignment1
{
    class Question28
    {
        // This method creates a simple menu system using do-while and switch
        public static void Run()
        {
            int choice;

            // Menu keeps running until user chooses to exit
            do
            {
                // Display menu options
                Console.WriteLine("---- MENU ----");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine()!);

                // Perform operation based on user choice
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Addition");
                        break;

                    case 2:
                        Console.WriteLine("You selected Subtraction");
                        break;

                    case 3:
                        Console.WriteLine("You selected Multiplication");
                        break;

                    case 4:
                        Console.WriteLine("Exiting menu");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }

                Console.WriteLine();

            } while (choice != 4);
        }
    }
}
