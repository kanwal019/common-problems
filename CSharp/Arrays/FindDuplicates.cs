/*
 * Print duplicte values in an array input through console
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays;

public class FindDuplicates
{
    public static void DisplayResult()
    {
        string line = Console.ReadLine();
        int count = Convert.ToInt32(line);
        line = Console.ReadLine();

        int[] array = new int[count];
        array = line.Split().Select(str => int.Parse(str)).ToArray();

        Console.WriteLine(FindDuplicateElementsSansDict(array, count));
    }

    private static string FindDuplicateElements(int[] array, int count)
    {
        string str = "";
        Dictionary<int, int> Elements = new();

        for(int i = 0; i < count; i++)
        {
            if (Elements.ContainsKey(array[i]))
            {
                if (!str.Contains(array[i].ToString()))
                {
                    str += (array[i] + " ");
                }                   
                Elements[array[i]] += 1;
                continue;
            }
            Elements.Add(array[i], 1);
        }
        return str.Trim();
    }

    private static string FindDuplicateElementsSansDict(int[] array, int count)
    {
        string str = "";
        bool[] isAssigned = new bool[count];

        for (int i = 0; i < count; i++)
        {
            if (isAssigned[array[i]])
            {
                if (!str.Contains(array[i].ToString()))
                {
                    str += (array[i] + " ");
                }                   
                continue;
            }
            isAssigned[array[i]] = true;
        }
        return str.Trim();
    }
}
