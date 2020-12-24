/*
 * You have been given an integer array A of size N. You need to print the number with the value closest to zero. If there are multiple elements, print the number with greater value
 * 
 * Read input from the console -
 *  - First line contains an interger N denoting the size of A
 *  - Next line conatins N comma separated elements of A
 *  
 * Print the value of the element closest to zero. If there are multiple candidates, then print the number with greater value.
 */

using System;
using System.Linq;

namespace CSharp.Searching
{
    public class ClosestToZero
    {
        static public void DisplayResult()
        {
            String line;
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);
            line = Console.ReadLine();
            int[] A = new int[N];
            A = line.Split().Select(str => int.Parse(str)).ToArray();

            int out_ = ReturnOutput(N, A);
            Console.Out.WriteLine(out_);
        }
        static int ReturnOutput(int N, int[] A)
        {
            int result = Int32.MaxValue;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(A[i]) <= result)
                {
                    if (Math.Abs(A[i]) == result && result > A[i])
                    {
                        continue;
                    }
                    result = A[i];
                }
            }
            return result;
        }
    }
}
