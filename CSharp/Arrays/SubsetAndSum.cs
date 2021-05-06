/*
 * In a given array find subsets whose sum matches the mentioned integer
 */

using System;
using System.Collections.Generic;

namespace CSharp.Arrays
{
    public class SubsetAndSum
    {
        public static void DisplayResult()
        {
            int[] array = new int[] { 1, -2, -1, 0, 6, 5, -3, -5 };
            int sum = 5;

            GetSubsets(array, sum, array.Length);
        }

        private static void GetSubsets(int[] array, int sum, int count)
        {
            HashSet<List<int>> set = new HashSet<List<int>>();
            List<int> list = new List<int>();
            bool pairFound = false;

            for(int i = 0; i < count; i++)
            {
                //list = FindElements(array, sum, count, list);

            }

            if (!pairFound)
            {
                Console.WriteLine("Unable to find a pair in the array whose sum equals " + sum);
            }
        }

        //private static List<int> FindElements(int[] array, int sum, int count, List<int> list)
        //{
                
        //}
    }
}
