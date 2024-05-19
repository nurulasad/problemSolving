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

    // Complete the getWays function below. DP
    static long getWays(long n, long[] c)
    {

        long[] ways = new long[(int)n + 1];

        ways[0] = 1;

        for (int i = 0; i < c.Length; i++)
        {


            for (int j = 0; j < ways.Length; j++)
            {
                if (c[i] <= j)
                {

                    ways[j] += ways[(int)(j - c[i])];
                }
            }
        }

        return ways[(int)n];
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        long[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt64(cTemp))
        ;
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'

        long ways = getWays(n, c);
        Console.WriteLine(ways);
        textWriter.Write(ways);

        textWriter.Flush();
        textWriter.Close();
    }
}
