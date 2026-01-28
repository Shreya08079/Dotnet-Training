using System;

public class CompatibilityCheck
{
    public static void Main()
    {
        Console.WriteLine("Enter name 1:");
        string name1 = Console.ReadLine();

        Console.WriteLine("Enter name 2:");
        string name2 = Console.ReadLine();

        bool valid1 = IsValidName(name1);
        bool valid2 = IsValidName(name2);

        if (!valid1 && !valid2)
        {
            Console.WriteLine($"Both {name1} and {name2} are invalid names");
            return;
        }
        if (!valid1)
        {
            Console.WriteLine($"{name1} is an invalid name");
            return;
        }
        if (!valid2)
        {
            Console.WriteLine($"{name2} is an invalid name");
            return;
        }

        if (IsSubsequence(name1, name2) || IsSubsequence(name2, name1))
        {
            Console.WriteLine($"{name1} and {name2} are made for each other");

            int compatibilityValue = Math.Abs(name1.Length - name2.Length);
            Console.WriteLine("Compatibility value is " + compatibilityValue);
        }
        else
        {
            Console.WriteLine($"{name1} and {name2} are not made for each other");
        }
    }

    static bool IsValidName(string name)
    {
        foreach (char character in name)
        {
            if (!(char.IsLetter(character) || character == ' '))
                return false;
        }
        return true;
    }

    static bool IsSubsequence(string s1, string s2)
    {
        int smallerIndex = 0;
        int largerIndex = 0;

        while (smallerIndex < s1.Length && largerIndex < s2.Length)
        {
            if (s1[smallerIndex] == s2[largerIndex])
                smallerIndex++;

            largerIndex++;
        }

        return smallerIndex == s1.Length;
    }
}
