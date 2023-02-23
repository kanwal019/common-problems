namespace CSharp.Sorting;

public class MergeSort
{
    public static void DisplayResult()
    {
        int[] unsortedArray = new int[] { 1, -2, -1, 0, 6, 5, -3, -5 };
        Sort(ref unsortedArray, 0, unsortedArray.Length - 1);
        Common.Display.Array(unsortedArray);
    }

    public static void Sort(ref int[] array, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            Sort(ref array, start, mid);
            Sort(ref array, mid + 1, end);
            Merge(ref array, start, mid, end);
        }
    }

    private static void Merge(ref int[] array, int start, int mid, int end)
    {
        int p = start, q = mid + 1;

        int[] arr = new int[end - start + 1];
        int k = 0;

        for (int i = start; i <= end; i++)
        {
            if (p > mid)
                arr[k++] = array[q++];

            else if (q > end)
                arr[k++] = array[p++];

            else if (array[p] < array[q])
                arr[k++] = array[p++];

            else
                arr[k++] = array[q++];
        }

        for (int i = 0; i < k; i++)
        {
            array[start++] = arr[i];
        }
    }
}
