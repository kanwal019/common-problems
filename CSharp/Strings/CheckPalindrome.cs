/*
 * Checks if the string is a Palindrome
 * 
 * Takes the string as input
 * 
 * Returns "True" if the string is Palindrome else returns "False"
 */
using System;

namespace CSharp.Strings;

public class CheckPalindrome
{
    public static void DisplayResult()
    {
        string str = Console.ReadLine();
        Console.WriteLine(IsPalindrome(str));
    }

    private static string IsPalindrome(string str)
    {
        string current = str.Replace(" ", string.Empty);
        for (int left = 0, right = current.Length - 1; left < right; left++, right--)
        {
            if (current[left] != current[right])
            {
                return bool.FalseString;
            }
        }
        return bool.TrueString;
    }
}
