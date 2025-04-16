/*
 * Write a program to find the smallest missing number(N) from an array. N >= 1
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp.Searching;

public class SmallestMissingNumber
{
    public static void Find(int[] arr)
    {
        ArgumentNullException.ThrowIfNull(arr);

        int smallestMissing = 1;
        Array.Sort(arr);

        foreach (int element in arr)
        {
            if (element > 0)
            {
                if (element == smallestMissing)
                {
                    smallestMissing++;
                }
                else if (element > smallestMissing)
                {
                    Console.WriteLine(smallestMissing);
                    return;
                }
            }
        }
        Console.WriteLine(smallestMissing);
    } 
}
