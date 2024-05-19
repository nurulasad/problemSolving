using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the diagonalDifference function below.
    //solved
    static int diagonalDifference(int[][] arr)
    {
        int leftD = 0;
        int rightD = 0;
        for(int i = 0, j = arr[0].Length-1;i < arr[0].Length; i++,j--)
        {
            leftD +=  arr[i][i];
            rightD += arr[i][j];
        }

        return Math.Abs(leftD - rightD);

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[][] arr = new int[n][];

        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //}

        int[][] arr = new int[3][];
        arr[0] = new int[] { 1, 2, 3 };
        arr[1] = new int[] { 4, 5, 6 };
        arr[2] = new int[] { 9, 8, 9 };

        int result = diagonalDifference(arr);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
