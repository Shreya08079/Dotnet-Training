using System;
using System.Collections.Concurrent;
namespace HelloDotnet
{
    public static class String
    {
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            int Left = 0;
            int right = str.Length-1;
            while(Left < right)
            {
                if(str[Left] != str[right])
                {
                    return false;
                }
                Left++;
                right--;
                
            }
            return true;
        }
    

    public static void Run()
        {
            string word = "madam";
            if (word.IsPalindrome())
            {
                Console.WriteLine($"\"{word}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{word}\" is not a palindrome.");
            }
        }
    }
}