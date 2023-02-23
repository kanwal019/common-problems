namespace CSharp.Sorting;

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        int count = array.Length;
        for (int i = 1; i < count; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j -= 1;
            }
            array[j + 1] = key;
        }
        Common.Display.Array(array);
    }

    public static void Descending(int[] array)
    {
        int count = array.Length;
        for (int i = 1; i < count; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] < key)
            {
                array[j + 1] = array[j];
                j -= 1;
            }
            array[j + 1] = key;
        }
        Common.Display.Array(array);
    }
}
