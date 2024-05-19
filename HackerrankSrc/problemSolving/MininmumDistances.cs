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

    // Complete the minimumDistances function below.
    //Solved
    static int minimumDistances(int[] a)
    {
        Dictionary<int, int[]> minimumDistances = new Dictionary<int, int[]>();

        int[] range = new int[2];

        for (int i = 0;i < a.Length; i++)
        {
            
            if (!minimumDistances.ContainsKey(a[i]))
            {
                minimumDistances.Add(a[i], new int[2] { int.MaxValue, int.MinValue});
            }
            range = minimumDistances[a[i]];

            if(i < range[0])
            {
                range[0] = i;
            }
            if(i > range[1])
            {
                range[1] = i;
            }
        }

        int min = int.MaxValue;
        foreach(KeyValuePair<int, int[]> entry  in minimumDistances)
        {
            int[] r = entry.Value;
            int d = r[1] - r[0];
            if(d < min && d > 0)
            {
                min = d;
            }
        }
        if (min == int.MaxValue)
            return -1;
        return min;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        //;
        int result = minimumDistances(new int[]{ 7, 1});

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
