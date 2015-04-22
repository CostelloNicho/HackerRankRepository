using System;
using System.Collections.Generic;

public class Solution
{
    private static void Main(string[] args)
    {
        //Read 
        var input = Console.ReadLine();
        int integerCount;
        int.TryParse(input, out integerCount);

        //Gather integers
        var integerInput = Console.ReadLine().Split(' ');
        var integers = new int[integerCount];
        for (int i = 0; i < integerCount; i++)
        {
            integers[i] = int.Parse(integerInput[i]);
        }

        //Find lonel integers
        Console.WriteLine(FindLonelyInteger(integers));
    }


    public static int FindLonelyInteger(int[] ints)
    {
        var values = new List<int>();
        for (int i = 0; i < ints.Length; i++)
        {
            if (values.Contains(ints[i]))
            {
                values.Remove(ints[i]);
            }
            else
            {
                values.Add(ints[i]);
            }
        }
        return values[0];
    }

}
