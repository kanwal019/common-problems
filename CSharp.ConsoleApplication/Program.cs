using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 6, 4, 1, 3, 7, 8, 5, 0, 2 };
            Searching.SecondLargestMissingNumber.Find(array);

            //Strings.ReverseWords.DisplayResult();                
        }        
    }
}
