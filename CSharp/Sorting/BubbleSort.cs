/*
 * You have been given an array A of size N . you need to sort this array non-decreasing oder using bubble sort. However, you do not need to print the sorted array . You just need to print the number of swaps required to sort this array using bubble sort
 * 
 * Read console for the input -
 *  - The first line consists of a single integer N denoting size of the array. The next line contains N space separated integers denoting the elements of the array
 *  
 * Print the required answer in a single line as output
 */

using System;
using System.Linq;

namespace CSharp.Sorting
{
    public class BubbleSort
    {
        public static void DisplayResult()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            int[] array = new int[length];

            foreach (int i in Enumerable.Range(0, length))
            {
                array[i] = Convert.ToInt32(input[i]);
            }

            Console.WriteLine(CalculateSwaps(array, length));
        }

        private static int CalculateSwaps(int[] array, int length)
        {
            int swaps = 0;
            int temp = 0;

            foreach (int i in Enumerable.Range(0, length - 1))
                foreach (int j in Enumerable.Range(0, length - 1))
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swaps += 1;
                    }
                }

            return swaps;
        }
    }
}
