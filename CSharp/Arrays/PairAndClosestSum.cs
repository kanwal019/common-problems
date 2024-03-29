﻿/*
 * In a given array find a pair whose sum matches the mentioned integer
 */
using System;
using System.Collections.Generic;

namespace CSharp.Arrays;

public class PairAndClosestSum
{
    public static void DisplayResult()
    {
        int[] input = { 1, 5, 22, 10, 17 };
        int sum = 14;

        GetClosestPairV2(input, sum);
    }

    private static void GetClosestPair(int[] input, int sum)
    {
        Dictionary<int, string> diffPairs = new();
        int nearest = sum;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }

                int key = Math.Abs(sum - (input[j] + input[i]));
                if (!diffPairs.TryGetValue(key, out _))
                    diffPairs.Add((key), input[j] + "," + input[i]);
            }
        }

        foreach (var pair in diffPairs)
        {
            if (pair.Key < nearest)
            {
                nearest = pair.Key;
            }
        }

        Console.WriteLine("(" + diffPairs[nearest] + ")");
    }

    private static void GetClosestPairV2(int[] input, int sum)
    {
        Array.Sort(input);
        int res_l = 0, res_r = 0;
        int l = 0, r = input.Length - 1, diff = sum;

        while (r > l)
        {
            if (Math.Abs(input[l] + input[r] - sum) < diff)
            {
                res_l = l;
                res_r = r;
                diff = Math.Abs(input[l] + input[r] - sum);
            }

            if (input[l] + input[r] > sum)
            {
                r -= 1;
            }
            else
            {
                l += 1;
            }
        }

        Console.Write("(" + input[res_l] + "," + input[res_r] + ")");
    }
}
