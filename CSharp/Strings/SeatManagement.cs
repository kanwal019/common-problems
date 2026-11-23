using System;
using System.Collections.Generic;

namespace CSharp.Strings;

public class SeatManagement
{
    public static void DisplayResult(int rows, string reserved)
    {
        var reservedSeats = new Dictionary<int, List<char>>();
        if (!string.IsNullOrEmpty(reserved))
        {
            foreach (var seat in reserved.Split(' '))
            {
                int row = int.Parse(seat[..^1]);
                char col = seat[^1];
                if (!reservedSeats.TryGetValue(row, out var seats))
                {
                    seats = [];
                    reservedSeats.Add(row, seats);
                }
                seats.Add(col);
            }
        }

        int ways = 0, flag1 = 0, flag2 = 0;
        for (int row = 1; row <= rows; row++)
        {
            if (reservedSeats.TryGetValue(row, out var seats))
            {
                flag1 = 0;

                if (!seats.Contains('B') && !seats.Contains('C') && !seats.Contains('D') && !seats.Contains('E'))
                {
                    flag1 += 1;
                }

                if (!seats.Contains('F') && !seats.Contains('G') && !seats.Contains('H') && !seats.Contains('J'))
                {
                    flag1 += 1;
                }

                if (flag1 != 2)
                {
                    flag2 = 0;

                    if (!seats.Contains('D') && !seats.Contains('E') && !seats.Contains('F') && !seats.Contains('G'))
                    {
                        flag2 += 1;
                    }

                    if (seats.Contains('D') && !(seats.Contains('F') || seats.Contains('G') || seats.Contains('H') || seats.Contains('J')))
                    {

                        flag2 += 1;
                    }
                    if (seats.Contains('G') && !(seats.Contains('B') || seats.Contains('C') || seats.Contains('D') || seats.Contains('E')))
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
