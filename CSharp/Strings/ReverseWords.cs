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

        static void ReverseArray2(char[] str)
        {
            int start = 0, end = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    start = 0;
                }
                   
                if (str[i] == ' ')
                {
                    end = i - 1;
                    ReverseString(str, start, end);
                    start = i + 1;
                }
                if (i == str.Length - 1)
                {
                    end = i;
                    ReverseString(str, start, end);
                }
            }
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

        private static void ReverseString(char[] str, int start, int end)
        {
            while (start < end)
            {
                str[start] ^= str[end];
                str[end] ^= str[start];
                str[start] ^= str[end];
                ++start;
                --end;
            }
        }
    }
}
