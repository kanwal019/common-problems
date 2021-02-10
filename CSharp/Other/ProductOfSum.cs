using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Other
{
    public class ProductOfSum
    {
        public static void DisplayResult()
        {
            DisplayPOS(1);
            DisplayPOS(2);
            DisplayPOS(3);
            DisplayPOS(4);
        }

        static void DisplayPOS(int num)
        {
            int prod = 1;
            while (num > 0)
            {
                // prod *= (num + (num + 1) + (num + 2));
                prod *= (3 * (num + 1));
                num -= 1;
            }
            Console.WriteLine(prod);
        }
    }
}
