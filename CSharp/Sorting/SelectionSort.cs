/*
 * You are given an array a, size of the array N and an integer x. Follow the above algorithm and print the state of the array after x iterations have been performed -
 *  - Consider an Array a of size N
 *  - Iterate from 1 to N
 *  - In i(th) iteration select the i(th) minimum and swap it with a[i]
 *  
 * Read the input from console -
 *  - The first line contains two integer N and x denoting the size of the array and the steps of the above algorithm to be performed respectively
 *  - The next line contains N space separated integers denoting the elements of the array
 *  
 * Print N space separated integers denoting the state of the array after x steps as output
 */

using System;
using System.Linq;

namespace CSharp.Sorting
{
    public class SelectionSort
    {
        public static void DisplayResult()
        {
            var input1 = Console.ReadLine().Split();
            int length = Convert.ToInt32(input1[0]);
            int iterations = Convert.ToInt32(input1[1]);

            var input2 = Console.ReadLine().Split(' ');
            int[] array = new int[length];

            foreach (int i in Enumerable.Range(0, length))
            {
                array[i] = Convert.ToInt32(input2[i]);
            }

            PrintArray(array, length, iterations);
        }

        private static void PrintArray(int[] array, int length, int iterations)
        {
            int min = 0;
            int temp = 0;
            int count = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if (count >= iterations)
                {
                    break;
                }

                min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
                count += 1;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write((i != length - 1) ? (array[i] + " ") : array[i].ToString());
            }
        }
    }
}
