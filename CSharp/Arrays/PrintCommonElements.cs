using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays
{
    public class PrintCommonElements
    {
        public static void DisplayResult()
        {
            int[] array1 = { 40, 50, 60, 45 };
            int[] array2 = { 10, 40, 30, 45, 20, 15 };

            int count1 = array1.Length;
            int count2 = array2.Length;

            Console.WriteLine(PrintLeastCommonV2(array1, array2, count1, count2));
        }

        private static int PrintLeastCommon(int[] array1, int[] array2, int count1, int count2)
        {
            int it1 = 0, it2 = 0;

            Array.Sort(array1);
            Array.Sort(array2);

            while (it1 < count1 || it2 < count2)
            {
                if(array1[it1] < array2[it2])
                {
                    it1 += 1;
                }
                else if(array1[it1] > array2[it2])
                {
                    it2 += 1;
                }
                else
                {
                    return array1[it1];
                }
            }

            return -1;
        }

        private static int PrintLeastCommonV2(int[] array1, int[] array2, int count1, int count2)
        {
            Array.Sort(array1);
            Array.Sort(array2);

            for (int i = 0; i < count1; i++)
            {
                if (Array.IndexOf(array2, array1[i]) != -1)
                {
                    return array1[i];
                }
            };

            return -1;
        }
    }
}
