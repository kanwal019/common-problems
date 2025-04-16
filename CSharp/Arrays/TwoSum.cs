using System;
using System.Collections.Generic;

/**

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

**/
namespace CSharp.Arrays;

public static class TwoSum
{
    public static void DisplayResult()
    {
        int[] array = [3, 2, 4];
        int target = 6;

        foreach (int item in GetOutput2(array, target))
        {
            Console.WriteLine(item);
        }
    }

    public static int[] GetOutput(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return null;
    }

    public static int[] GetOutput2(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        Dictionary<int, int> keyValuePairs = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (keyValuePairs.TryGetValue(difference, out int value))
            {
                return [value, i];
            }

            if (!keyValuePairs.ContainsKey(nums[i]))
            {
                keyValuePairs[nums[i]] = i;
            }
        }
        throw new ArgumentException($"Can't find two numbers with sum equal to {target}");
    }
}
