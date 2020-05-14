using System;

using static System.Math;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(Pow(10, 9));
    }
}