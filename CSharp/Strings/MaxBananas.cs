/*
 * Write a program that a given string of a length N, return the maximum number of moves that can be applied -
 * 
 * In one move six letters forming the word 'BANANA'(One 'B', 3 'A's and two 'N's) can be deleted from the string.
 */
using System;

namespace CSharp.Strings;

internal class MaxBananas
{
    public static int Find(string str)
    {
        int b = 0, a = 0, n = 0;

        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'B': b += 1; break;
                case 'A': a += 1; break;
                case 'N': n += 1; break;
                default: break;
            }
        }

        a /= 3;
        n /= 2;

        return Math.Min(b, Math.Min(a, n));
    }
}
