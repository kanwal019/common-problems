using System;
using System.Text;

namespace CSharp.Other;

public class PalindromeSum
{
    public static void DisplayResult()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DisplayPalindromeSum(input));
    }

    static int DisplayPalindromeSum(int number)
    {
        int sum = number + ReverseNumber(number);
        if(sum == ReverseNumber(sum))
        {
            return sum;
        }
        return DisplayPalindromeSum(sum);
    }

    static int ReverseNumber(int number)
    {
        string str = number.ToString();
        StringBuilder sb = new();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return Convert.ToInt32(sb.ToString());
    }
}
