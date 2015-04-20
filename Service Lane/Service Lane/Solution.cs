// Copyright 2015 Nicholas Costello <NicholasJCostello@gmail.com>
using System;
using System.Linq;

public class Solution
{
    private static int lengthOfHightway;
    private static int numberOfTests;

    private static int[] widths;

    private static void Main(string[] args)
    {

        ParseLengthOfHightwayAndTestCases();
        ParseSegmentWidthArray();

        //Gather test input
        for (int index = 0; index < numberOfTests; ++numberOfTests)
        {
            //Read and split the string
            var testCaseInput = Console.ReadLine();
            var testCase = testCaseInput.Split(' ');

            //Parse the integers
            int entryIndex; //Length of freeway
            int exitIndex; //Number of test cases
            int.TryParse(testCase[0], out entryIndex);
            int.TryParse(testCase[1], out exitIndex);

            Console.WriteLine(GetLargestVehicle(widths, entryIndex, exitIndex));
        }
        

    }

    private static void ParseLengthOfHightwayAndTestCases()
    {
        //Read and split the string
        var input = Console.ReadLine();
        if (input == null) return;
        var splitInput = input.Split(' ');

        //Parse the integers
        int.TryParse(splitInput[0], out lengthOfHightway);
        int.TryParse(splitInput[1], out numberOfTests);
    }

    private static void ParseSegmentWidthArray()
    {
        widths = new int[lengthOfHightway];
        var widthsInput = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
        widths = Array.ConvertAll(widthsInput, c => (int)char.GetNumericValue(c));
    }

    private static int GetLargestVehicle(int[] width, int entry, int exit)
    {
        var lowestSegmentWidth = 3;
        for (var index = entry; index <= exit; index++)
        {
            if (width[index] < lowestSegmentWidth)
                lowestSegmentWidth = width[index];
        }
        return lowestSegmentWidth;
    }
}