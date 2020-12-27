using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {               
                int min = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }                
                }                   

                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            Common.Display.Array(array);
        }

        public static void Descending(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }

                int temp = array[max];
                array[max] = array[i];
                array[i] = temp;
            }
            Common.Display.Array(array);
        }
    }
}
