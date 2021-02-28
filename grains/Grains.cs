using System;

public static class Grains
{
	const int MAX_NUMBER_ON_BOARD = 64;
	
    public static ulong Square(int n)
    {
        if (n <= 0 || n > MAX_NUMBER_ON_BOARD)
        {
            throw new ArgumentOutOfRangeException();
        }
        return (ulong) Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        return (ulong) Math.Pow(2, MAX_NUMBER_ON_BOARD) - 1;
    }
}