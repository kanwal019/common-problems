/*
 * Find the number of cyclic shifts required to create the largest possible binary number from the string foth nth time. The string contains the binary number.
 * 
 * Read input from the console
 *  - First line contains the number of cases
 *  - Second line contains the binary string
 *  
 * Display the number of shifts required for each case as output.
 */

using System;

namespace CSharp.DataStructures
{
    public class MaximumBinaryNumber
    {
        public static void DisplayResult()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                var firstLine = Console.ReadLine().Split();
                int length = Convert.ToInt32(firstLine[0]);
                int count = Convert.ToInt32(firstLine[1]);
                string binaryString = Console.ReadLine();
                CalculateShiftsToMax(binaryString, length, count);
            }
        }

        static void CalculateShiftsToMax(string binaryString, int length, int count)
        {
            string current = binaryString;
            string max = binaryString;
            int shifts = 0;
            int thisCount = 0;

            while(thisCount != count)
            {
                char first = current[0];
                current = current.Substring(1);
                current += first;
                shifts += 1;

                CheckMax(current, ref max, length);

                if (current == binaryString)
                {
                    thisCount++;
                }
            }

            Console.WriteLine(shifts - 1);
        }

        static void CheckMax(string current, ref string max, int length)
        {
            if(length%2 != 0)
            {
                if(Convert.ToInt32(current[0]) > Convert.ToInt32(max[0]))
                {
                    max = current;
                    return;
                }
                else if(Convert.ToInt32(current[0]) < Convert.ToInt32(max[0])) 
                {
                    return;
                }

                if(IsCurrentStringMax(current.Substring(1), max.Substring(1)))
                {
                    max = current;
                }
            }
            else
            {
                if (IsCurrentStringMax(current, max))
                {
                    max = current;
                    return;
                }
            }
        }

        static bool IsCurrentStringMax(string current, string max)
        {
            if(Convert.ToInt32(current.Substring(0,2)) > Convert.ToInt32(max.Substring(0, 2)))
            {
                return true;
            } 
            else if(Convert.ToInt32(current.Substring(0, 2)) < Convert.ToInt32(max.Substring(0, 2)))
            {
                return false;
            }

            if(current.Length > 2)
            {
                return IsCurrentStringMax(current.Substring(2), max.Substring(2));
            }
            else
            {
                return false;
            }              
        }
    }
}
