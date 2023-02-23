using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays;

public class PrintUncommonElements
{
    public static void DisplayResult()
    {
        int[] array1 = { 40, 50, 60, 45 };
        int[] array2 = { 10, 40, 30, 45, 20, 15 };

        int count1 = array1.Length;
        int count2 = array2.Length;

        PrintUncommonV3(array1, array2, count1, count2);
    }

    private static void PrintUncommon(int[] array1, int[] array2, int count1, int count2)
    {
        int it1 = 0, it2 = 0;

        Array.Sort(array1);
        Array.Sort(array2);

        while (it1 < count1 && it2 < count2)
        {
            if(array1[it1] < array2[it2])
            {
                Console.WriteLine(array1[it1] + " ");
                it1 += 1;
            }
            else if(array1[it1] > array2[it2])
            {
                Console.WriteLine(array2[it2] + " ");
                it2 += 1;
            }
            else
            {
                it1 += 1;
                it2 += 1;
            }
        }

        while(it1 < count1 || it2 < count2)
        {
            if (it1 < count1)
            {
                Console.WriteLine(array1[it1]);
                it1 += 1;
            }

            if (it2 < count2)
            {
                Console.WriteLine(array2[it2]);
                it2 += 1;
            }
        }
    }

    private static void PrintUncommonV2(int[] array1, int[] array2, int count1, int count2)
    {
        array1 =  array1.Concat(array2).ToArray();
        Array.Sort(array1);

        Dictionary<int, int> elementCount = new();

        for(int i = 0; i < array1.Length; i++)
        {
            if (elementCount.ContainsKey(array1[i]))
            {
                elementCount[array1[i]] += 1;
                continue;
            }
            elementCount.Add(array1[i], 1);
        }

        for(int i = 0; i < array1.Length; i++)
        {
            if(elementCount[array1[i]] == 1)
            {
                Console.Write(array1[i] + " ");
            }
        }
    }

    private static void PrintUncommonV3(int[] array1, int[] array2, int count1, int count2)
    {
        Array.Sort(array1);
        Array.Sort(array2);

        List<int> uncommon = new();

        for (int i = 0; i < count1; i++)
        {
            if (Array.IndexOf(array2, array1[i]) == -1)
            {
                uncommon.Add(array1[i]);
            }
        };

        for (int i = 0; i < count2; i++)
        {
            if (Array.IndexOf(array1, array2[i]) == -1)
            {
                uncommon.Add(array2[i]);
            }
        };

        foreach(var item in uncommon)
        {
            Console.Write(item + " ");
        }
    }
}
