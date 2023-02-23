using System;

namespace CSharp.Arrays;

public class DoubleOnMatch
{
    public static void DisplayResult()
    {
        int[] array = { 1, 2, 4, 11, 12, 8 };
        Console.WriteLine(ProcessSize(array, 2));
    }

    static int ProcessSize(int[] array, int num)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                num *= 2;
            }
        }
        return num;
    }
}
