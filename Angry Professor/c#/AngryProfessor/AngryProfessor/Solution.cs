/************************************************************
 Problem Statement

The professor is conducting a course on Discrete Mathematics to a class of N students. He is angry at the lack of their discipline, and he decides to cancel the class if there are less than K students present after the class starts.

Given the arrival time of each student, your task is to find out if the class gets cancelled or not.

Input Format

The first line of the input contains T, the number of test cases. Each test case contains two lines. 
The first line of each test case contains two space-separated integers, N and K. 
The next line contains N space-separated integers, a1,a2,…,aN, representing the arrival time of each student.

If the arrival time of a given student is a non-positive integer (ai≤0), then the student enters before the class starts. If the arrival time of a given student is a positive integer (ai>0), the student enters after the class has started.

Output Format

For each testcase, print "YES" (without quotes) if the class gets cancelled and "NO" (without quotes) otherwise.

Constraints

1≤T≤10
1≤N≤1000
1≤K≤N
−100≤ai≤100,where i∈[1,N]
Note 
If a student enters the class exactly when it starts (ai=0), the student is considered to have entered before the class has started.
 **************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class Solution
{
    private static void Main(string[] args)
    {
        //Read number of test cases
        var inputTestCases = Console.ReadLine();
        if (inputTestCases == null) return;
        //Parse test cases
        var numberOfTestCase = 0;
        int.TryParse(inputTestCases, out numberOfTestCase);

        for (var i = 0; i < numberOfTestCase; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var k = int.Parse(input[1]);

            //Read and split the string
            var studentsInput = Console.ReadLine();
            var students = studentsInput.Split(' ');

            Console.WriteLine(IsClassCanceled(students, k));
        }
    }

    private static string IsClassCanceled(IEnumerable<string> students, int k)
    {
        var counter =
            students.Select(student => int.Parse(student))
                .Count(current => current >= 0);

        return counter >= k ? "No" : "Yes";
    }
}