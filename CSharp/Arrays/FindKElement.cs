﻿/*
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

namespace CSharp.Arrays;

public class FindKElement
{
    public static void DisplayResult()
    {
        string line = Console.ReadLine();
        int count = Convert.ToInt32(line);

        for (int i = 0; i < count; i++)
        {
            line = Console.ReadLine();
            int iCount = Convert.ToInt32(line);
            line = Console.ReadLine();
            var iList = line.Split().Select(int.Parse).ToList();
            line = Console.ReadLine();
            int iPosition = Convert.ToInt32(line);
            Console.WriteLine(FindLargest(iList, iCount, iPosition));
        }
    }

    private static int FindLargest(List<int> iList, int iCount, int iPosition)
    {
        int count = iCount;

        for(int i = 0; i < count; i++)
        {
            for(int j = 0; j < count; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int diff = Math.Abs(iList[i] - iList[j]);

                if (!iList.Contains(diff))
                {
                    iList.Add(diff);
                    count++;
                }
            }
            
        }

        iList.Sort();

        if (iPosition <= iList.Count) 
        {
            return iList[^iPosition];
        }

        return -1;
    }
}
