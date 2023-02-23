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
        string reverse = "";
        for (int i = current.Length - 1; i >= 0; i--)
        {
            reverse += current[i].ToString();
        }
        return (reverse == current).ToString();
    }
}
