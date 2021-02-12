/*
 * In a given array find a pair whose sum matches the mentioned integer
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Arrays
{
    public class PairAndClosestSum
    {
        public static void DisplayResult()
        {
            int[] input = { 1, 5, 22, 10, 17 };
            int sum = 12;

            GetClosestPair(input, sum);
        }

        private static void GetClosestPair(int[] input, int sum)
        {
            Dictionary<int, string> diffPairs = new Dictionary<int, string>();
            int nearest = sum;
            string temp = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    int key = Math.Abs(sum - (input[j] + input[i]));

                    if (!diffPairs.TryGetValue(key, out temp))
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
    }
}
