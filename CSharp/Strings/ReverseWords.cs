/*
 * Reverses the words of a given string retaining all the spaces.
 */

using System;
using System.Text;

namespace CSharp.Strings
{
    public class ReverseWords
    {
        public static void DisplayResult()
        {
            //var input = "I drive with Bolt";
            var input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Console.WriteLine(ReverseArray(inputArray));
        }

        private static string ReverseArray(char[] inputArray)
        {
            string input = new string(inputArray);
            StringBuilder output = new StringBuilder();
            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                output.Append(ReverseString(words[i]));
                if (i < words.Length - 1)
                {
                    output.Append(" ");
                }
            }
            return output.ToString();
        }

        private static string ReverseString(string input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }
            return output.ToString();
        }
    }
}
