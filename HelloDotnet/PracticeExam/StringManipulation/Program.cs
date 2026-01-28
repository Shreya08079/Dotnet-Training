using System;

public class StringManipulation
{
    public static void Main()
    {
        Console.WriteLine("Enter the sentence: ");
        string input = Console.ReadLine();

        long length = input.Length;  

        // Validate characters
        for (int charIndex = 0; charIndex < length; charIndex++)
        {
            char currentChar = input[charIndex];
            if (!(currentChar >= 'A' && currentChar <= 'Z') &&
                !(currentChar >= 'a' && currentChar <= 'z') &&
                currentChar != ' ')
            {
                Console.WriteLine("Invalid Sentence.");
                return;
            }
        }

        string[] words = input.Split(' ');

        int wordCount = 0;
        for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        {
            if (words[wordIndex] != "")
            {
                wordCount++;
            }
        }

        Console.WriteLine("Word Count: " + wordCount);

        // If word count is even reverse word order
        if (wordCount % 2 == 0)
        {
            for (int reverseIndex = words.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                if (words[reverseIndex] != "")
                {
                    Console.Write(words[reverseIndex] + " ");
                }
            }
        }
        // If word count is odd reverse each word
        else
        {
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                if (words[wordIndex] != "")
                {
                    for (int letterIndex = words[wordIndex].Length - 1; letterIndex >= 0; letterIndex--)
                    {
                        Console.Write(words[wordIndex][letterIndex]);
                    }
                    Console.Write(" ");
                }
            }
        }
    }
}
