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

namespace CSharp.Sorting
{
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

            Sort(ref array, 0, length - 1);
        }

        public static void Sort(ref int []array, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Sort(ref array, start, mid);
                Sort(ref array, mid + 1, end);              
                Merge(ref array, start, mid, end);
            }
        }

        private static void Merge(ref int[] array, int start, int mid, int end)
        {
            int p = start, q = mid + 1;

            int[] arr = new int[end - start + 1];
            int k = 0;

            for (int i = start; i <= end; i++)
            {
                if (p > mid)
                    arr[k++] = array[q++];

                else if (q > end)
                    arr[k++] = array[p++];

                else if (array[p] < array[q])
                    arr[k++] = array[p++];

                else
                    arr[k++] = array[q++];
            }

            for (int i = 0; i < k; i++)
            {
                array[start++] = arr[i];
            }
        }
    }
}
