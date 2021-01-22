using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Searching
{
    public class BinarySearch
    {
        public static void DisplayResult()
        {
            int[] array = { 10, 40, 30, 45, 20, 15 };
            int num = 45;

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Array.Sort(array);

            Console.WriteLine();
            Console.WriteLine(num + " found at position " + Search(array, num) + " in the mentioned array !!");
        }

        static int Search(int[] array, int num)
        {
            int min = 0;
            int max = array.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                
                if(num == array[mid])
                {
                    return ++mid;
                }

                if(num < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}
