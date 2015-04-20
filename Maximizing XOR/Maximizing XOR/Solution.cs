// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>

using System;

internal class Solution
{
    private static int maxXor(int l, int r)
    {
        var largest = 0;
        for (var i = l; i <= r; ++i)
        {
            for (var j = l; j <= r; j++)
            {
                var xor = j ^ i;
                if (largest < xor)
                    largest = xor;
            }
        }
        return largest;
    }

    private static void Main(String[] args)
    {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());

        int _r;
        _r = Convert.ToInt32(Console.ReadLine());

        res = maxXor(_l, _r);
        Console.WriteLine(res);
    }
}