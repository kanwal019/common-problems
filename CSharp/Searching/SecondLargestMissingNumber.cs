/*
 * Write a program to find the second to the largest missing number(N) from an array. N >= 1
 */

using System;

namespace CSharp.Searching;

public class SecondLargestMissingNumber
{
    public static void Find(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);

        int largestMissing = arr[^1];
        largestMissing = largestMissing >= 1 ? largestMissing : 1;

        foreach (int element in arr)
        {
            if (element > 0)
            {
                if (largestMissing == element)
                {
                    largestMissing -= 1;
                }
                else if (largestMissing > element)
                {
                    Console.WriteLine(largestMissing);
                    return;
                }
            }
        }
        Console.WriteLine(largestMissing);
    } 
}
