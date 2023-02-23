/* 
 * Checks the Complete String(i.e. if the string contains all characters from a to z)
 * 
 * Reads input from the console
 *  - First line contains the number of input strings(assume n)
 *  - Rest n lines contains the input string
 *  
 * Output should be displayed as "YES" or "NO" for each string 
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp.Strings;

public class CompleteString
{
    public static void DisplayResult()
    {
        var length = Convert.ToInt32(Console.ReadLine());
        List<string> input = new();

        for (int i = 0; i < length; i++)
        {
            input.Add(Console.ReadLine());
        }

        foreach (var i in input)
        {
            if (Regex.IsMatch(i, @"^[a-zA-Z]+$"))
            {
                if (i.Length >= 26)
                {
                    if (ContainsAll(i.ToLower()))
                    {
                        Console.WriteLine("YES");
                        continue;
                    }
                }
            }
            Console.WriteLine("NO");
        }
    }

    private static bool ContainsAll(string str)
    {
        bool[] check = new bool[26];

        for (int i = 0; i < str.Length; i++)
        {
            check[str[i] - 'a'] = true;
        }

        for (int i = 0; i < 26; i++)
        {
            if (!check[i])
            {
                return false;
            }
        }
        return true;
    }
}