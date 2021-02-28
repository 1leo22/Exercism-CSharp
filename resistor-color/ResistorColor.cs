using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    enum Color
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9
    }

    public static int ColorCode(string color)
    {
        Color colorCode =  (Color) Enum.Parse(typeof(Color), color, true);

        return (int) colorCode;
    }

    public static string[] Colors() => Enum.GetNames(typeof(Color));
}