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

class Result
{

    /*
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        List<int> res = new List<int>();

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (i == j)
                    continue;

                if (arr[i] + arr[j] == m)
                {
                    if (i < j)
                    {
                        res.Add(i+1);
                        res.Add(j+1);
                    }
                    else
                    {
                        res.Add(j+1);
                        res.Add(i+1);
                    }

                }
            }
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.icecreamParlor(m, arr);

            //textWriter.WriteLine(String.Join(" ", result));
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
