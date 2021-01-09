using System;

namespace CSharp.Arrays
{
    public class PrintUncommonElements
    {
        public static void DisplayResult()
        {
            int[] array1 = { 40, 50, 60, 45 };
            int[] array2 = { 10, 40, 30, 45, 20, 15 };

            int count1 = array1.Length;
            int count2 = array2.Length;

            PrintUncommon(array1, array2, count1, count2);
        }

        private static void PrintUncommon(int[] array1, int[] array2, int count1, int count2)
        {
            int it1 = 0, it2 = 0;

            Array.Sort(array1);
            Array.Sort(array2);

            while (it1 < count1 && it2 < count2)
            {
                if(array1[it1] < array2[it2])
                {
                    Console.WriteLine(array1[it1] + " ");
                    it1 += 1;
                }
                else if(array1[it1] > array2[it2])
                {
                    Console.WriteLine(array2[it2] + " ");
                    it2 += 1;
                }
                else
                {
                    it1 += 1;
                    it2 += 1;
                }
            }

            while(it1 < count1 || it2 < count2)
            {
                if (it1 < count1)
                {
                    Console.WriteLine(array1[it1]);
                    it1 += 1;
                }

                if (it2 < count2)
                {
                    Console.WriteLine(array2[it2]);
                    it2 += 1;
                }
            }
        }
    }
}
