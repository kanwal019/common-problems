/*
 * You are given an array A of N integers. Calculate the amgic value of array A. Magic value of an array is equal to the difference between the sum of good integers in an array and sum of bad integers in an array.
 * 
 * Good integers are the ones whose indexes are not changed when an array id sorted, rest are bad.
 * 
 * Reads the input from console -
 *  - First line contains an integer N i.e. Size of the array
 *  - Second N spaced integers are the elements of the array.
 *  
 * Print a single integer i.e. magic value
 */

using System;
using System.Linq;

namespace CSharp.Arrays
{
    class MagicValue
    {
        public static void DisplayResult() 
        {
            String line = Console.ReadLine();
            int count = Convert.ToInt32(line);
            line = Console.ReadLine();

            int[] array = new int[count];
            array = line.Split().Select(str => int.Parse(str)).ToArray();

            int[] iArray = new int[count];
            int good = 0, bad = 0;

            Array.Copy(array, iArray, count);
            Array.Sort(array);

            for (int i = 0; i < count; i++)
            {
                if (array[i] == iArray[i])
                    good += array[i];
                else
                    bad += array[i];
            }

            Console.WriteLine(good - bad);
        }
    }
}
