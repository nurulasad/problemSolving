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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int valleyCount = 0;

        bool inValley = false;
        int depth = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'D')
            {
                depth++;
                if(depth > 0 && inValley == false)
                {
                    inValley = true;
                }
            }
            else if(s[i] == 'U')
            {
                depth--;
                if(depth == 0 && inValley == true)
                {
                    valleyCount++;
                    inValley = false;
                }
            }

        }
        return valleyCount;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //string s = Console.ReadLine();

        int result = countingValleys(8, "DUDUUDDU");

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
