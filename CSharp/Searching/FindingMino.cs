/*
 * You have been given an Unimodal function:
 * 
 * f(x) = 2x^2 - 12x + 7
 * 
 * with N intervals. For each interval you will be given two integer values l and r , where l <= r and you need to find the minimum value of f(x) where x will be in the range [l,r] (both inclusive).
 * 
 * Reads input from the console -
 *  - The first line will consists of one integer N denoting the number of intervals.
 *  - In next N lines, each line contains 2 space separated integers, l and r denoting the range of interval.
 * 
 * Print N lines, where i(th) line denotes the minimum value of f(x), where x will be in range [l(i),r(i)].
 */

using System;
using System.Linq;

namespace CSharp.Searching
{
    public class FindingMino
    {
        public static void DisplayResult()
        {
            int length = Convert.ToInt32(Console.ReadLine());

            foreach (int i in Enumerable.Range(0, length))
            {
                _ = i;
                var input = Console.ReadLine().Split(' ');
                Console.WriteLine(Math.Round(Mino(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]))));
            }
        }

        private static double Func(double x)
        {
            return 2 * Math.Pow(x, 2) - 12 * x + 7;
        }

        public static double Mino(double start, double end)
        {
            double left = start;
            double right = end;
            foreach (int i in Enumerable.Range(0, 200))
            {
                double mid1 = left + (right - left) / 3;
                double mid2 = right - (right - left) / 3;
                if (Func(mid1) < Func(mid2))
                {
                    right = mid2;
                }
                else
                {
                    left = mid1;
                }
            }
            return Func(left);
        }

        /*private static int TernarySearch(int left, int right, int i, int []array)
        {
            if (right >= left)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;
                if (array[mid1] == i)
                    return mid1;
                if (array[mid2] == i)
                    return mid2;
                if (i < array[mid1])
                    return TernarySearch(left, mid1 - 1, i, array);
                else if (i > array[mid2])
                    return TernarySearch(mid2 + 1, right, i, array);
                else
                    return TernarySearch(mid1 + 1, mid2 - 1, i, array);
            }
            return -1;
        }*/
    }
}
