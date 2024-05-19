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

    // Complete the miniMaxSum function below.
    //sovled
    static void miniMaxSum(int[] arr)
    {

        Array.Sort<int>(arr);

        long min = 0;
        for (int i = 0; i < 4; i++)
        {
            min += arr[i];
        }

        long max = 0;
        for (int i = 1; i < 5; i++)
        {
            max += arr[i];
        }

        Console.WriteLine(min + " " + max);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
