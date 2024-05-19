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

    // Complete the birthdayCakeCandles function below.
    //solved
    static int birthdayCakeCandles(int[] ar)
    {

        Array.Sort(ar);

        int count = 0;
        int tallest = ar[ar.Length-1];
        for(int i = ar.Length-1; i>=0; i--)
        {
            if(ar[i] == tallest)
            {
                count++;
            }
            else
            {
                break;
            }
        }

        return count;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int arCount = Convert.ToInt32(Console.ReadLine());

        //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //;

        int[] ar = new int[4] { 3, 2, 1, 3 };
        int result = birthdayCakeCandles(ar);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
