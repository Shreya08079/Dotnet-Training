using System;

class LoginAttemptsExceededException : Exception
{
    public LoginAttemptsExceededException(string message) : base(message)
    {
    }
}

class LoginSystem
{
    static void Main()
    {
        int attempts = 0;
        string correctPassword = "shreya08";

        try
        {
            while (true)
            {
                Console.WriteLine("Enter password:");
                string input = Console.ReadLine()!;
                attempts++;

                if (input == correctPassword)
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }

                if (attempts >= 3)
                {
                    throw new LoginAttemptsExceededException(
                        "Login failed: Maximum login attempts exceeded."
                    );
                }
            }
        }
        catch (LoginAttemptsExceededException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Application terminated.");
        }
    }
}
