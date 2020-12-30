﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Sorting
{
    public class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }                   
            }
            Common.Display.Array(array);
        }

        public static void Descending<T>(T[] array) where T : IComparable
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Common.Display.Array(array);
        }

        public static void Optimised<T>(T[] array) where T : IComparable
        {
            int i, j;
            int count = array.Length;
            bool swapped;

            for (i = 0; i < count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < count - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
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
