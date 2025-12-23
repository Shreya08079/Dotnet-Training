using System;

namespace HelloDotnet.Assignment1
{
    class Question14
    {
        // This method simulates a 2-player Rock-Paper-Scissors game
        public static void Run()
        {
            // Variables to store player choices

            string player1;
            string player2;

            // Taking choices from both players
            Console.Write("Player 1, please enter your choice (rock/paper/scissors): ");
            player1 = Console.ReadLine()!.ToLower();

            Console.Write("Player 2, please enter your choice (rock/paper/scissors): ");
            player2 = Console.ReadLine()!.ToLower();

            // Checking game result using nested if

            //user will enter their choice in lowercase letters
            if (player1 == player2)
            {
                Console.WriteLine("It's a draw! Try again.");
            }
            else if (player1 == "rock")
            {
                if (player2 == "scissors")
                    Console.WriteLine("yayyyy!!!!Player 1 wins!");
                else
                    Console.WriteLine("yayyyy!!!!Player 2 wins!");
            }
            else if (player1 == "paper")
            {
                if (player2 == "rock")
                    Console.WriteLine("yayyyy!!!!Player 1 wins!");
                else
                    Console.WriteLine("yayyyy!!!!Player 2 wins!");
            }
            else if (player1 == "scissors")
            {
                if (player2 == "paper")
                    Console.WriteLine("yayyyy!!!!Player 1 wins!");
                else
                    Console.WriteLine("yayyyyy!!!!Player 2 wins!");
            }
            else
            {
                Console.WriteLine("Invalid input from Player 1");
            }
        }
    }
}
