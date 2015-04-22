// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static void Main(string[] args)
    {
        //Read and split the string
        var inputTestCases = Console.ReadLine();
        if (inputTestCases == null) return;

        //Parse input
        var numberOfTestCase = 0;
        int.TryParse(inputTestCases, out numberOfTestCase);

        var inputIntegers = Console.ReadLine().Split(' ');

        var values = new List<int>();
        for (var i = 0; i < numberOfTestCase; i++)
            values.Add(int.Parse(inputIntegers[i]));

        CutIntegers(values);
    }

    private static void CutIntegers(List<int> values)
    {
        int numberOfCuts = 0;

        if (values.Count == 0)
            return;

        var min = values.Min();

        for (var i = 0; i < values.Count; i++)
        {
            values[i] -= min;
            if (values[i] <= 0)
            {
                values.Remove(values[i]);
                i--;
            }

            numberOfCuts++;
        }
        Console.WriteLine(numberOfCuts);
        CutIntegers(values);
    }
}