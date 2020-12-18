/*
 * You are given container full of water. Container can have limited amount of water. You also have N bottles to fill. You need to find the maximum numbers of bottles you can fill
 * 
 * Reads input from console -
 *  - First line contains one integer, T, number of test cases
 *      - First line of each test case contains two integer, N and X, number of bottles and capacity of the container
 *      - Second line of each test case contains N space separated integers, capacities of bottles
 *      
 * For each test case print the maximum number of bottles you can fill
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DynamicProgramming
{
    public class GreedyForWater
    {
        public static void DisplayResult()
        {
            int count = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ');
                int number = Convert.ToInt32(input[0]);
                int capacity = Convert.ToInt32(input[1]);
                var capacities = Console.ReadLine().Split(' ');
                int[] array = new int[number];

                for (int j = 0; j < number; j++)
                {
                    array[i] = Convert.ToInt32(capacities[j]);
                }
                
            }
        }
    }
}
