using System;

namespace CSharp.Searching
{
    public class SmallestMissingNumber
    {
        public static void Find(int[] arr)
        {
            int smallestMissing = 1;
            Array.Sort(arr);

            foreach (int element in arr)
            {
                if (element > 0)
                {
                    if (element == smallestMissing)
                    {
                        smallestMissing++;
                    }
                    else if (element > smallestMissing)
                    {
                        Console.WriteLine(smallestMissing);
                    }
                }
            }
            Console.WriteLine(smallestMissing);
        } 
    }
}
