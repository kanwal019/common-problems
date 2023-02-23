using System;

namespace CSharp.DynamicProgramming;

public class StringWithout3A3B
{
    public static void DisplayResult()
    {
        Console.WriteLine(Solution(1, 4));
        Console.WriteLine(Solution(5, 3));
    }

    private static string Solution(int A, int B)
    {
        string str = "";

        while (A > 0 || B > 0)
        {
            bool appendA = false;

            if (str.Length >= 2 && str[^1] == str[^2])
            {
                if (str[^1] == 'b')
                    appendA = true;
            }
            else
            {
                if (A >= B)
                    appendA = true;
            }

            if (appendA)
            {
                A -= 1;
                str += "a";
            }
            else
            {
                B -= 1;
                str += "b";
            }
        }

        return str;
    }
}
