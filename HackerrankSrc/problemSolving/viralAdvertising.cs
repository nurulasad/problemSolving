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

    // Complete the viralAdvertising function below.
    //solved
    static int viralAdvertising(int n)
    {
        int csum = 0;
        int likedToday = 0;
        int sharedToday = 5;
        for(int i = 1; i <= n; i++)
        {
            likedToday = sharedToday / 2;
            csum += likedToday;
            sharedToday = likedToday * 3;
        }

        return csum;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(5);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
