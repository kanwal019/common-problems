using System;
using System.Collections.Generic;

namespace CSharp.Arrays;

public class ArraySubset
{
    public static void DisplayResult()
    {
        int[] array1 = { 10, 40, 30, 45, 20, 15, 60, 50 };
        int[] array2 = { 40, 50, 60, 45 };

        Console.WriteLine(IsSubset(array1, array2));
    }

    static bool IsSubset(int[] parent, int[] child)
    {
        HashSet<int> set = new();
        int count = 0;

        for (int i = 0; i < child.Length; i++)
        {
            set.Add(child[i]);
        }

        for (int i = 0; i < parent.Length; i++)
        {
            if (set.Contains(parent[i]))
            {
                count += 1;
            }
        }

        return (count == set.Count);
    }
}
