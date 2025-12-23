using System;

namespace HelloDotnet.Assignment1
{
    class Question25
    {
        // This method runs a guessing game using do-while loop
        public static void Run()
        {
            // Variable to store secret number and user guess
            int secretNumber = 7;   // Assuming secret number
            int guess;

            // Guessing game loop
            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine()!);

                if (guess != secretNumber)
                {
                    Console.WriteLine("Wrong guess, try again");
                }

            } while (guess != secretNumber);

            // When user guesses correctly
            Console.WriteLine("Congratulations! You guessed the correct number");
        }
    }
}
