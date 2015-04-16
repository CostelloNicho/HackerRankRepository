// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>

using System;

internal class Solution
{
    private static void Main(string[] args)
    {
        //Find the number of inputs expected
        int numberOfExpectedInputs;
        int.TryParse(Console.ReadLine(), out numberOfExpectedInputs);

        for (var i = 0; i < numberOfExpectedInputs; ++i)
        {
            //Read and split the string
            var input = Console.ReadLine();
            var splitInput = input.Split(' ');

            //Parse the integers
            int constant1;
            int constant2;
            if (!int.TryParse(splitInput[0], out constant1)) break;
            if (!int.TryParse(splitInput[1], out constant2)) break;

            //Calculate the sum
            Console.WriteLine(ComputeSum(constant1, constant2));
        }
    }

    //Simply computes a sum
    private static int ComputeSum(int a, int b)
    {
        return a + b;
    }
}