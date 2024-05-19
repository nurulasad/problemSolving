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

    // Complete the findDigits function below.
    //solved
    static int findDigits(int n)
    {
        char[] s = n.ToString().ToCharArray();

        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int d = int.Parse("" + s[i]);
            if (d == 0)
                continue;

            if(n%d == 0)
            {
                count++;
            }
        }

        return count;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int t = Convert.ToInt32(Console.ReadLine());

        //for (int tItr = 0; tItr < t; tItr++)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int result = findDigits(n);

        //    textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();

        int result = findDigits(1111);
    }
}
