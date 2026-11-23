/*
 * Print duplicte values in an array input through console
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays;

public class FindDuplicatesFrequency
{
    public static void DisplayResult()
    {
        string line = Console.ReadLine();
        int count = Convert.ToInt32(line);
        line = Console.ReadLine();

        int[] array = [.. line.Split().Select(int.Parse)];

        FindDuplicateElementsFrequencySanDict(array, count);
    }

    private static void FindDuplicateElementsFrequency(int[] array, int count)
    {
        Dictionary<int, int> Elements = [];

        for (int i = 0; i < count; i++)
        {
            if (Elements.TryGetValue(array[i], out int frequency))
            {
                Elements[array[i]] = frequency + 1;
                continue;
            }
            Elements.Add(array[i], 1);
        }

        foreach (var element in Elements)
        {
            if (element.Value > 1)
            {
                Console.WriteLine(element.Key + " occured " + element.Value + " times.");
            }
        }
    }

    private static void FindDuplicateElementsFrequencySanDict(int[] array, int count)
    {
        int[] frequency = new int[count];

        for (int i = 0; i < count; i++)
        {
            frequency[array[i]] += 1;
        }

        for (int i = 0; i < count; i++)
        {
            if (frequency[i] > 1)
            {
                Console.WriteLine(i + " occured " + frequency[i] + " times.");
            }
        }
    }
}
