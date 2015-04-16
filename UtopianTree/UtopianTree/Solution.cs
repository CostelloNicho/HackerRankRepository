// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>

using System;

internal class Solution
{
    private static void Main(string[] args)
    {
        //Get the number of test cases
        int numberOfTestCases;
        if (!int.TryParse(Console.ReadLine(), out numberOfTestCases)) return;

        //Loop through each test case
        for (var i = 0; i < numberOfTestCases; i++)
        {
            //Get the number of cycles
            int numberOfCycles;
            if (!int.TryParse(Console.ReadLine(), out numberOfCycles)) break;

            //Calculate the height depending on the cycles
            var height = 0;
            for (var j = 0; j <= numberOfCycles; j++)
                height += j%2 == 0 ? 1 : height;

            Console.WriteLine(height);
        }
    }
}