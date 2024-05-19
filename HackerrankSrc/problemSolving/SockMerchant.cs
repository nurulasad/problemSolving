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

    // Complete the sockMerchant function below.
    //solved
    static int sockMerchant(int n, int[] ar)
    {
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        for(int i = 0; i< ar.Length; i++)
        {
            if(!pairs.ContainsKey(ar[i])){

                pairs.Add(ar[i], 0);

            }

            pairs[ar[i]] = pairs[ar[i]] + 1;
        }

        int count = 0;
        foreach(int key in pairs.Keys)
        {
            if(pairs[key] >=2)
            {

                count += pairs[key]/2;
            }
        }
        return count;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //;

        //int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        int[] ar = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
        int result = sockMerchant(10, ar);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
