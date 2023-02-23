using System;

namespace CSharp.Common;

public class Display
{
    public static void Array<T>(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(array[i] + " ");
        }        
        Console.WriteLine();
    }
}
