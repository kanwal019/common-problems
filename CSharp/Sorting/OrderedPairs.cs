/*
 * Given an array A on size N, you need to find the number of ordered pairs (i,j) such that i<j and A[i]>A[j]
 * 
 * Reads input from the console -
 *  - First line contains one integer, N, size of array
 *  - Second line contains N space separated integers denoting the elements of the array A.
 *  
 * Print the number of ordered pairs (i,j) such that i<j and A[i]>A[j] as output
 */

using System;
using System.Linq;

namespace CSharp.Sorting;

public class OrderedPairs
{
    public static void DisplayResult()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        var input = Console.ReadLine().Split(' ');
        int[] array = new int[length];

        foreach (int i in Enumerable.Range(0, length))
        {
            array[i] = Convert.ToInt32(input[i]);
        }

        MergeSort.Sort(ref array, 0, length - 1);
    }      
}
