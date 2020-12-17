/*
 * You have been given an array A consisting of N integers. All the elements in this array A are unique. You have to answer some queries based on the elements of this array. Each query will consist of a single integer x. You need toprint the rank based position of this element in this array considering that the array is 1 indexed. The rank based position of an element in an array is its position in the array when the array has been sorted in ascending order.
 * 
 * Reads input from the console
 *  - The first line consists of a single integer N denoting the size of array A. The next line contains N unique        integers, denoting the content of array A. The next line contains a single integer q denoting the number of        queries. Each of the next q lines contains a single integer x denoting the element whose rank based position       needs to be printed.
 *  
 * You need to print q integers denoting the answer to each query.
 */

using System;

namespace CSharp.Searching
{
    public class RankIt
    {
        public static void DisplayResult()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ');
            int[] array = new int[length];

            for(int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(FindIndex(Convert.ToInt32(Console.ReadLine()), array));
            }
        }
        private static string FindIndex(int i, int[] array)
        {
            int left = 0;
            int right = array.Length-1;
            return BinarySearch(left, right, i, array).ToString();
        }

        private static int BinarySearch(int left, int right, int i, int[] array)
        {
            int mid = (left + right) / 2;

            if (array[mid] < i)
            {
                return BinarySearch(mid + 1, right, i, array);
            }
            else if (array[mid] > i)
            {
                return BinarySearch(left, mid - 1, i, array);
            }

            return mid + 1;
        }
    }
}
