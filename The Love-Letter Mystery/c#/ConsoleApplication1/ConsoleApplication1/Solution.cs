// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static List<string> _testCases;

    private static void Main(string[] args)
    {
        //Initialize 
        _testCases = new List<string>();

        //Gather data
        GatherTestCases();

        //Run each
        foreach (string testCase in _testCases)
            Console.WriteLine(PalendromeNumberOfOperations(testCase));
    }

    private static int PalendromeNumberOfOperations(string str)
    {
        var operationCount = 0;

        //Find the number of iterations needed
        var iterations = str.Count()%2 == 0 ? (str.Count()/2) : (str.Count() - 1)/2;
        //Convert to char array
        var palindrome = str.ToCharArray();
        for (var i = 0; i < iterations; i++)
        {
            //Get ascii codes of chars
            int x = palindrome[i];
            int y = palindrome[palindrome.Count() - 1 - i];
            //Add the difference to the op count
            operationCount += Math.Abs(x - y);
        }
        return operationCount;
    }

    private static void GatherTestCases()
    {
        //Read and split the string
        var input = Console.ReadLine();
        int testCaseCount;
        int.TryParse(input, out testCaseCount);

        //Read in all test Cases
        for (var i = 0; i < testCaseCount; i++)
        {
            var testCase = Console.ReadLine();
            _testCases.Add(testCase);
        }
    }
}