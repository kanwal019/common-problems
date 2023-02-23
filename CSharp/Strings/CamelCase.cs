/*
 * Takes any string and converts it into camel case
 * 
 * Reads input from the console and removes spaces and special characters from the string.
 * 
 * Output is written to the console.
 */
    
using System;
using System.Text.RegularExpressions;

namespace CSharp.Strings;

public class CamelCase
{
    public static void DisplayResult()
    {
        string str = Console.ReadLine();
        Console.WriteLine(ConvertToCamelCase(str));
    }

    private static string ConvertToCamelCase(string str)
    {
        var array = Regex.Split(str, @"[^0-9a-zA-Z]+");
        string result = "";

        for (int i = 0; i < array.Length; i++)
        {
            string temp = array[i].ToLower();
            result += (i != 0) ? (temp[0].ToString().ToUpper() + temp[1..]) : temp;
        }
        return result;
    }
}
