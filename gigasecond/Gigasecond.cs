using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
       const long GIGASECOND = 1000000000;

       return moment.AddSeconds(GIGASECOND);
    }
}