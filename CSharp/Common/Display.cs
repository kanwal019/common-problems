using System;

namespace CSharp.Common;

public class Display
{
    public static void Array<T>(T[] array)
    {
        if (array is not null)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        throw new ArgumentNullException(nameof(array));
    }
}
