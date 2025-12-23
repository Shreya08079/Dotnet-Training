using System;
namespace HelloDotnet.Assignment1
{
    class Question7
    {
        // This method checks whether the given character is a vowel or consonant
        public static void Run()
        {
            char ch;
            // Taking character input from user

            Console.Write("Enter a character: ");
            ch = char.Parse(Console.ReadLine()!);
            // Checking if the character is a vowel or consonant

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                 Console.WriteLine("Entered character is a Vowel.");
                 break;

                 default:
                    Console.WriteLine("Entered character is a Consonant.");
                    break;
            }

        }
    }
}
 