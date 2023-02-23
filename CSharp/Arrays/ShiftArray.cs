/*
 * Assume that strings can be stored in a cache(limit 5). If the string is present in the cache, it is brought to the top by performing a cyclic shift on the cache. If a new string is added, the string at the bottom is pushed out of the array
 * 
 * Reads input from the console -
 *  - Line 1 contains the size of the string array, i.e. n
 *  - Following n lines contains the array elements
 *  
 *  Output cache is displayed in the form of string1-string2...-string5
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Arrays;

public class ShiftArray
{
    public static void DisplayResult()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[length];
       
        for (int i=0; i < length; i++)
        {
            array[i] = Console.ReadLine();
        }

        Console.WriteLine(ArrayChallenge(array));
    }

    private static string ArrayChallenge(string[] array)
    {
        List<string> cache = new();
        string result = "";

        for (int i = 0; i < array.Length; i++)
        {
            if (cache.Contains(array[i]))
            {
                cache.Remove(array[i]);
            }
            else
            {
                if(cache.Count >= 5 && cache.Count > 0)
                {
                    var temp = cache.First();
                    cache.Remove(temp);
                }                
            }
            cache.Add(array[i]);
        }

        foreach(var item in cache)
        {
            result += item;
            result += "-";
        }

        return result.Substring(0,9);
    }
}
