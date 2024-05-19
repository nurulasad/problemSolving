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

    // Complete the camelcase function below.
    //solved
    static int camelcase(string s)
    {
        int count = 1;
        for(int i = 1; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                count++;
            }
            
        }

        return count;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();

        int result = camelcase("aaBaseDepth");

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}