/*
 * Checks the Last Occurence of an integer from a number of integers
 * 
 * Reads input from the console
 *  - The first line consists of 2 integers denoting the size of the array and the element to be searched for in the array
 *  - The next line contains space separated integers denoting the elements of of the array
 *  
 * Display output as a single integer denoting the index of the last occurrence of integer M in the array if it exists, otherwise display -1.
 */  

using System;

namespace CSharp.Searching;

public class LastOccurence
{
    public static void DisplayResult()
    {
        var input1 = Console.ReadLine().Split(' ');
        var input2 = Console.ReadLine().Split(' ');

        int length = Convert.ToInt32(input1[0]);
        int element = Convert.ToInt32(input1[1]);

        for (var i = length; i > 0; i--)
        {
            if(Convert.ToInt32(input2[i-1]) == element)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine("-1");
    }
}
