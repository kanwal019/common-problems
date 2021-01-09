/*
 * Given an array A of N numbers, where every element occurs even number of times, except one element (which occurs odd number of times), find the unique element, which occurs odd number of times.
 * 
 * Reads input from the console -
 *  - First line contains an integer T, representing the no.of testcases to follow.
 *  - The first line of each testcase contains an integer N, denoting the array size. N spaced numbers then follow in the next line, denoting the array elements.
 *  
 *  Writes output to the console -
 *  - For i'th testcase, Print on a new line "Case %d: x", where x denotes the answer to the i'th testcase.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays
{
    public class FindUniqueOne
    {
        public static void DisplayResult()
        {
            String line = Console.ReadLine();
            int count = Convert.ToInt32(line);

            for (int i = 0; i < count; i++)
            {
                line = Console.ReadLine();
                int iCount = Convert.ToInt32(line);
                line = Console.ReadLine();
                var iList = line.Split().Select(str => int.Parse(str)).ToList();
                Console.WriteLine("Case " + (i + 1) + ": " + FindUnique(iList, iCount));
            }
        }

        private static int FindUnique(List<int> iList, int iCount)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            for (int i = 0; i < iCount; i++)
            {
                if (elementCount.ContainsKey(iList.ElementAt(i)))
                {
                    elementCount[iList.ElementAt(i)] += 1;
                    continue;
                }
                elementCount.Add(iList.ElementAt(i), 1);
            }

            for (int i = 0; i < iCount; i++)
            {
                if (elementCount[iList.ElementAt(i)] % 2 != 0)
                {
                    return iList.ElementAt(i);
                }
            }
            return -1;
        }
    }
}
