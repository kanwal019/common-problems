using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Sorting
{
    class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }                   
            }
            Common.Display.Array(array);
        }

        public static void Optimised(int[] array)
        {
            int i, j, temp;
            int count = array.Length;
            bool swapped;

            for (i = 0; i < count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
            Common.Display.Array(array);
        }
    }
}
