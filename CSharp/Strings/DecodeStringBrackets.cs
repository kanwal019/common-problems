using System;
using System.Collections;

namespace CSharp.Strings;

public class DecodeStringBrackets
{
    public static void DisplayResult()
    {
        Console.WriteLine(Decode("3[a]2[bc]"));
    }

    static string Decode(string str)
    {
        Stack stack = new();
        int num = 0;
        string current = "";

        for(int i = 0; i < str.Length; i++)
        {
            if (str[i] == '[')
            {
                stack.Push(current);
                stack.Push(num);
                current = "";
                num = 0;
            }
            else if(str[i] == ']')
            {
                _ = (int)stack.Pop();
                string previous = stack.Pop().ToString();

                string temp = "";

                for(int j = 0; j < num; j++)
                {
                    temp += current;
                }

                current = previous + temp;
            }
            else if (int.TryParse(str[i].ToString(), out _))
            {
                num = num * 10 + str[i];
            }
            else
            {
                current += str[i];
            }
        }

        return current;
    }
}
