/*
 * You are given an array containing N distinct integers. You perform the following operations on this array -
 *  - For each pair of integers, you find the absolute difference D between those integers and insert D into the array (if it was not already present in the array).
 *  - You repeat task 1 until the array becomes constant. This implies that the absolute difference between any two elements in the array is also an element present in the array.
 *  - Write a program to find the Kth largest element of the array after all the operations have been performed. If there is no such element, print -1.
 *  
 * Reads input from the console -
 *  - First line: T (Number of test cases)
 *  - First line in each test case: N
 *  - Second line in each test case: N space-separated integer (denoting the elements of the array)
 *  - Third line in each test case: K
 *  
 * For each test case, print the Kth largest element of the array. If there is no such element print -1.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Other
{
    public class FindKElement
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
                line = Console.ReadLine();
                int iPosition = Convert.ToInt32(line);
                Console.WriteLine(FindLargest(iList, iCount, iPosition));
            }
        }

        private static int FindLargest(List<int> iList, int iCount, int iPosition)
        {
            int diff = 0;
            List<int> dList = new List<int>();

            iList.Sort();

            foreach (var listItem in iList)
            {
                if (!dList.Contains(listItem))
                {
                    dList.Add(listItem);
                }

                for (int i = 0; i < iCount; i++)
                {                        
                    if (listItem > iList[i])
                    {
                        diff = listItem - iList[i];
                    }
                    else
                    {
                        diff = iList[i] - listItem;
                    }
                        
                    if (!dList.Contains(diff))
                    {
                        dList.Add(diff);
                    }                    
                }
            }

            dList.Sort();

            if (iPosition < dList.Count) 
            {
                return dList[dList.Count - iPosition];
            }

            return -1;
        }
    }
}
