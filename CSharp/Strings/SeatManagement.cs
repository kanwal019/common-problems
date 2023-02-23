using System;
using System.Collections.Generic;

namespace CSharp.Strings
{
    public class SeatManagement
    {
        public static void DisplayResult(int rows, string reserved)
        {
            var reservedSeats = new Dictionary<int, List<char>>();
            if (!string.IsNullOrEmpty(reserved))
            {
                foreach (var seat in reserved.Split(' '))
                {
                    int row = int.Parse(seat.Substring(0, seat.Length - 1));
                    char col = seat[seat.Length - 1];
                    if (!reservedSeats.ContainsKey(row))
                    {
                        reservedSeats[row] = new List<char>();
                    }
                    reservedSeats[row].Add(col);
                }
            }

            int ways = 0, flag1 = 0, flag2 = 0;
            for (int row = 1; row <= rows; row++)
            {
                if (reservedSeats.ContainsKey(row))
                {
                    flag1 = 0;

                    if (!reservedSeats[row].Contains('B') && !reservedSeats[row].Contains('C') && !reservedSeats[row].Contains('D') && !reservedSeats[row].Contains('E'))
                    {
                        flag1 += 1;
                    }

                    if (!reservedSeats[row].Contains('F') && !reservedSeats[row].Contains('G') && !reservedSeats[row].Contains('H') && !reservedSeats[row].Contains('J'))
                    {
                        flag1 += 1;
                    }

                    if (flag1 != 2)
                    {
                        flag2 = 0;

                        if (!reservedSeats[row].Contains('D') && !reservedSeats[row].Contains('E') && !reservedSeats[row].Contains('F') && !reservedSeats[row].Contains('G'))
                        {
                            flag2 += 1;
                        }

                        if (reservedSeats[row].Contains('D') && !(reservedSeats[row].Contains('F') ||reservedSeats[row].Contains('G') || reservedSeats[row].Contains('H') || reservedSeats[row].Contains('J')))
                        {

                            flag2 += 1;
                        }
                        if (reservedSeats[row].Contains('G') && !(reservedSeats[row].Contains('B') || reservedSeats[row].Contains('C') || reservedSeats[row].Contains('D') || reservedSeats[row].Contains('E')))
                        {
                            flag2 += 1;
                        }

                    }
                    if (flag1 > flag2)
                    {
                        ways += flag1;
                    }
                    else
                    {
                        ways += flag2;
                    }
                }
                else
                {
                    ways += 2;
                }

            }
            Console.WriteLine("Max number of families can be seated : " + ways);
        }
    }
}
