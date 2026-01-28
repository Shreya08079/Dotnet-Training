using System;

public class StringManipulation
{
    public static void Main()
    {
        Console.WriteLine("Enter the sentence: ");
        string input = Console.ReadLine();
        long len = input.Length

        for (var i = 0; i < len; i++)
        {
            char ch = input[i];
            if (!(ch >= 'A' && ch <= 'Z') &&
                !(ch >= 'a' && ch <= 'z') &&
                ch != ' ')
            {
                Console.WriteLine("Invalid Sentence.");
                return;
            }
        }

        string[] temp = input.Split(' ');

        int wordCount = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] != "")
            {
                wordCount++;
            }
        }

        Console.WriteLine("Word Count: " + wordCount);

        // If  even reverse word order
        if (wordCount % 2 == 0)
        {
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (temp[i] != "")
                {
                    Console.Write(temp[i] + " ");
                }
            }
        }
        // If word count is odd reverse each word
        else
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    for (int j = temp[i].Length - 1; j >= 0; j--)
                    {
                        Console.Write(temp[i][j]);
                    }
                    Console.Write(" ");
                }
            }
        }
    }
}
