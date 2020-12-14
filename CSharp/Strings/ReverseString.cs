/*
 * Reverses the a string
 * 
 * Reads input string from the console
 *  
 * Displays output(Reversed string) to the console
 */

using System;

namespace CSharp.Strings
{
    public class ReverseString
    {
        public static void DisplayResult()
        {
            var str = Console.ReadLine().ToLower();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char temp = (i == str.Length - 1) ? Char.ToUpper(str[i]) : str[i];
                Console.Write(temp);
            }
        }
    }
}
