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

class Solution2
{

    // Complete the strangeCounter function below.
    static int knapSack(int W, int[] wt,
                         int[] val, int n)
    {
        int i, w;
        int[,] K = new int[n + 1, W + 1];

        // Build table K[][] in bottom  
        // up manner 
        for (i = 0; i <= n; i++)
        {
            for (w = 0; w <= W; w++)
            {
                if (i == 0 || w == 0)
                    K[i, w] = 0;
                else if (wt[i - 1] <= w)
                    K[i, w] = Math.Max(val[i - 1]
                           + K[i - 1, w - wt[i - 1]],
                                    K[i - 1, w]);
                else
                    K[i, w] = K[i - 1, w];
            }
        }

        return K[n, W];

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //long t = Convert.ToInt64(Console.ReadLine());

        int[] val = new int[] { 2,5,10 };
        int[] wt = new int[] { 2,4,7 };
        int W = 10;
        int n = val.Length;

        long result = knapSack(W, wt, val, n);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
