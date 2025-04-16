using System;

namespace CSharp.Sorting;

public class SelectionSort
{
    public static void Sort(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
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

            (array[i], array[min]) = (array[min], array[i]);
        }
        Common.Display.Array(array);
    }

    public static void Descending(int[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
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

            (array[i], array[max]) = (array[max], array[i]);
        }
        Common.Display.Array(array);
    }
}
