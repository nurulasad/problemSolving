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

    // Complete the hourglassSum function below.
    //Solved
    static int hourglassSum(int[][] arr)
    {
        int sum, min, max;
        sum = 0;
        max = int.MinValue;

        for(int i = 0; i < 4; i++)
        {
            
            for(int j = 0; j < 4; j++)
            {
                sum = 0;
                sum += arr[i][j] + arr[i][j + 1]+arr[i][j+2];
                sum += arr[i + 1][j + 1];
                sum += arr[i+2][j] + arr[i+2][j + 1] + arr[i+2][j + 2];

                if(sum > max)
                {
                    max = sum;
                }
                
            }
        }
        return max;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] s = { "1 1 1 0 0 0", "0 1 0 0 0 0", "1 1 1 0 0 0", "0 0 2 4 4 0", "0 0 0 2 0 0", "0 0 1 2 4 0" };
        
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(s[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}