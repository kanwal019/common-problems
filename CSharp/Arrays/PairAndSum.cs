/*
 * In a given array find a pair whose sum matches the mentioned integer
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Arrays
{
    public class PairAndSum
    {
        public static void DisplayResult()
        {
            int[] array = new int[] { 1, -2, -1, 0, 6, 5, -3, -5 };
            int sum = 5;

            GetPair(array, sum, array.Length);
        }

        private static void GetPair(int[] array, int sum, int count)
        {
            HashSet<int> set = new HashSet<int>();
            bool pairFound = false;

            for(int i = 0; i < count; i++)
            {
                int diff = sum - array[i];
                if (set.Contains(diff))
                {
                    Console.WriteLine("Sum of pair (" + array[i] + "," + diff + ") equals " + sum);
                    pairFound = true;
                }
                set.Add(array[i]);
            }

            if (!pairFound)
            {
                Console.WriteLine("Unable to find a pair in the array whose sum equals " + sum);
            }
        }
    }
}
