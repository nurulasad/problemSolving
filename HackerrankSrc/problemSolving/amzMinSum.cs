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

    // Complete the cavityMap function below.
    //solved brute force
    static int minSum(int[] a)
    {

        Array.Sort(a);

        int csum = 0;
        int sum = 0;

        for(int i = 0; i < a.Length-1; i++)
        {
            sum = a[i]+a[i+1];
            csum += sum;
            a[i] = 0;
            a[i + 1] = sum;
            Array.Sort(a);

        }

        return csum;

    }

    

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //string[] grid = new string[n];

        //for (int i = 0; i < n; i++)
        //{
        //    string gridItem = Console.ReadLine();
        //    grid[i] = gridItem;
        //}

        
        int res = minSum(new int[] { 8,9,10,11});

        //textWriter.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
