/*
 * Storing data in a linked list in the for of HashMaps. Values for a key can't be overwritten.
 * 
 * Reads input from the console -
 *	- First line contains the number of inputs, n
 *	- Next n lines contain key value pairs seperated by space
 *	
 * Display the hashmap as output
 */

using System;
using System.Collections.Generic;

namespace CSharp.DataStructures;

public class LinkedListHashMap
{
    public static void DisplayResult()
    {
        int count = Convert.ToInt32(Console.ReadLine());
        HashMap hashMap = new();
        for (int i = 0; i < count; i++)
        {
            var line = Console.ReadLine().Split(' ');
            hashMap.Insert(line[0].Trim(), Convert.ToInt32(line[1].Trim()));
        }
        hashMap.Print();
    }

    public class Data
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }

    public class HashMap
    {
        private Data data;
        private readonly List<Data> list;

        public HashMap()
        {
            list = new List<Data>();
        }

        public void Insert(string iKey, int iValue)
        {
            data = new Data() { Key = iKey, Value = iValue };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key == iKey)
                {
                    return;
                }
            }
            list.Add(data);
        }

        public void Print()
        {
            foreach (var listItem in list)
            {
                Console.WriteLine(listItem.Key + " " + listItem.Value);
            }
        }
    }
}
