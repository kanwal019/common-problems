/*
 * Print duplicte values in an array input through console
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Arrays
{
    public class FindDuplicatesFrequency
    {
        public static void DisplayResult()
        {
            String line = Console.ReadLine();
            int count = Convert.ToInt32(line);
            line = Console.ReadLine();

            int[] array = new int[count];
            array = line.Split().Select(str => int.Parse(str)).ToArray();

            FindDuplicateElementsFrequency(array, count);
        }

        private static void FindDuplicateElementsFrequency(int[] array, int count)
        {
            Dictionary<int, int> Elements = new Dictionary<int, int>();

            for(int i = 0; i < count; i++)
            {
                if (Elements.ContainsKey(array[i]))
                {               
                    Elements[array[i]] += 1;
                    continue;
                }
                Elements.Add(array[i], 1);
            }
            
            foreach(var element in Elements)
            {
                if(element.Value > 1)
                {
                    Console.WriteLine(element.Key + " occured " + element.Value + " times.");
                }            
            }
        }
    }
}
