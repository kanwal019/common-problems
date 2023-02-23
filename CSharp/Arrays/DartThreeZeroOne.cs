using System;

namespace CSharp.Arrays;

public class DartThreeZeroOne
{
    public static void DisplayResult()
    {
        string[][] array = new string[][] {
            new string [] { "D10", "T2", "18", "17", "D19", "5" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "T17", "0" , "0" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "T17", "0" , "0", "11", "0", "0" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "20", "15", "0" , "T5" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "20", "15", "0" , "T5", "15" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "20", "5", "0", "SB" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "T10", "D10" },
            new string [] { "17", "T2", "17", "18", "17", "D19", "5" },
            new string [] { "D20", "T20", "T20", "T20", "T10", "1", "DB" }
        };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(DartThreeZeroOneFunc(array[i]));
        }
    }

    private static int DartThreeZeroOneFunc(string[] array)
    {
        int res = 301;
        int val = 0;
        bool start = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (int.TryParse(array[i], out _))
            {
                if (start)
                {
                    val += Convert.ToInt32(array[i]);
                }
            }
            else
            {
                if (array[i][0] == 'D')
                {
                    if (!start)
                    {
                        start = true;
                    }

                    if (array[i][1] != 'B')
                    {
                        val += (2 * Convert.ToInt32(array[i].Substring(1)));
                    }
                    else
                    {
                        val += 50;
                    }
                }
                else
                {
                    if (start)
                    {
                        if (array[i][1] != 'B')
                        {
                            val += (3 * Convert.ToInt32(array[i].Substring(1)));
                        }
                        else
                        {
                            val += 25;
                        }
                    }
                }
            }

            if ((i + 1) % 3 == 0 || (i + 1) == array.Length)
            {
                var t = res - val;

                if (t <= 1 && array[i][0] != 'D')
                {
                    val = 0;
                    continue;
                }

                res -= val;
                val = 0;
            }
        }

        return res;
    }
}
