﻿using System.CodeDom.Compiler;
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

    // Complete the circularArrayRotation function below.
    //solved
    static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
        int[] temp = new int[a.Length];
        int[] res = new int[queries.Length];

        for (int i = 0; i < a.Length; i++)
        {
            int newPos = (i + k) % a.Length;
            temp[newPos] = a[i];
        }

        for (int i = 0; i < queries.Length; i++)
        {
            res[i] = temp[queries[i]];
        }
        return res;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nkq = Console.ReadLine().Split(' ');

        //int n = Convert.ToInt32(nkq[0]);

        //int k = Convert.ToInt32(nkq[1]);

        //int q = Convert.ToInt32(nkq[2]);

        //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        //;

        //int[] queries = new int[q];

        //for (int i = 0; i < q; i++)
        //{
        //    int queriesItem = Convert.ToInt32(Console.ReadLine());
        //    queries[i] = queriesItem;
        //}

        //int[] result = circularArrayRotation(a, k, queries);

        //textWriter.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();

        int k = 0;

        //int q = Convert.ToInt32(nkq[2]);

        int[] a = { 5, 15, 30, 45, 90};

        int[] queries = { 1, 3 };

        //for (int i = 0; i < q; i++)
        //{
        //    int queriesItem = Convert.ToInt32(Console.ReadLine());
        //    queries[i] = queriesItem;
        //}

        int[] result = circularArrayRotation(a, k, queries);
    }
}
