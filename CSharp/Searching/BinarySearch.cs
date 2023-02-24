using System;
using System.Collections.Generic;

namespace CSharp.Searching;

public class BinarySearch
{
    public static void DisplayResult(int[] array, int num)
    {
        Dictionary<int, int> positions = new();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
            positions[array[i]] = i;
        }

        Array.Sort(array);
        Console.WriteLine();

        if (SearchRecursive(array, num, 0, array.Length - 1) != -1)
        // if (Search(array, num) != -1)
        {
            Console.WriteLine($"{num} found at position {positions[num]} in the mentioned array !!");
        }
        else
        {
            Console.WriteLine($"{num} not found at any position in the mentioned array !!");
        }
    }

    static int Search(int[] array, int num)
    {
        int min = 0;
        int max = array.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;

            if (num == array[mid])
            {
                return ++mid;
            }

            if (num < array[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return -1;
    }

    static int SearchRecursive(int[] array, int num, int min, int max)
    {
        if (min > max)
        {
            return -1;
        }

        int mid = (min + max) / 2;

        if (num == array[mid])
        {
            return ++mid;
        }

        if (num < array[mid])
        {
            return SearchRecursive(array, num, min, mid - 1);
        }

        return SearchRecursive(array, num, mid + 1, max);
    }
}
