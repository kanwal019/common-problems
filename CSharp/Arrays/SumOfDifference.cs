using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Arrays
{
    public class SumOfDifference
    {
        public static void DisplayResult()
        {
            int[] array = { 1, 3, 3, 2, 4 };
            Array.Sort(array);
            Console.WriteLine(MinimumDifference(array));
        }

        static int MinimumDifference(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                res += (Math.Abs(array[i] - array[i + 1]));
            }
            return res;
        }
    }
}
