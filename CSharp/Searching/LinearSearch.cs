using System;

namespace CSharp.Searching;

public class LinearSearch
{
    public static void DisplayResult()
    {
        int[] array = { 10, 40, 30, 45, 20, 15 };
        int num = 45;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }

        Array.Sort(array);

        Console.WriteLine();
        Console.WriteLine(num + " found at position " + Search(array, num) + " in the mentioned array !!");           
    }

    static int Search(int[] array, int num)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                return ++i;
            }
        }
        return -1;
    }
}
