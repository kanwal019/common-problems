using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Strings
{
    public class DecodeStringBrackets
    {
        public static void DisplayResult()
        {
            Console.WriteLine(Decode("3[a]2[bc]"));
        }

        static string Decode(string str)
        {
            Stack stack = new Stack();
            int num = 0, spare = 0;
            string previous = "", current = "";

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == '[')
                {
                    stack.Push(current);
                    stack.Push(num);
                    current = "";
                    num = 0;
                }
                else if(str[i] == ']')
                {
                    spare = (int)stack.Pop();
                    previous = stack.Pop().ToString();

                    string temp = "";

                    for(int j = 0; j < num; j++)
                    {
                        temp += current;
                    }

                    current = previous + temp;
                }
                else if (int.TryParse(str[i].ToString(), out int o))
                {
                    num = num * 10 + (int)str[i];
                }
                else
                {
                    current += str[i];
                }
            }

            return current;
        }
    }
}
