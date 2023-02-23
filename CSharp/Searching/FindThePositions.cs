/*
 * You have been given an A array consisting of N integers. All the elements in this array are guaranteed to be unique. For each position i in the array A you need to find the position A[i] should be present in, if the array was a sorted array. You need to find this for each i and print the resulting solution
 * 
 * The first line contains a single integer N denoting the size of array A. The next line contains N space separated integers denoting the elements of array A
 * 
 * Print N space separated integers on a single line , where the Ith integer denotes the position of A[i] if this array were sorted
 */

using System;
using System.Linq;

namespace CSharp.Searching;

public class FindThePositions
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

        FindPositions(array, length);
    }

    private static void FindPositions(int[] array, int length)
    {
        int[] arr = new int[length];
        
        for(int i = 0; i < length; i++)
        {
            arr[i] = array[i];
        }

        for (int i = 1; i < length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }

            arr[j + 1] = key;
        }

        for(int i = 0; i < length; i++)
        {
            Console.Write(BinarySearch(0, length - 1, array[i], arr) + " ");
        }
    }

    private static int BinarySearch(int left, int right, int i, int[] array)
    {
        int mid = (left + right) / 2;

        if (array[mid] < i)
        {
            return BinarySearch(mid + 1, right, i, array);
        }
        else if (array[mid] > i)
        {
            return BinarySearch(left, mid - 1, i, array);
        }

        return mid + 1;
    }
}
