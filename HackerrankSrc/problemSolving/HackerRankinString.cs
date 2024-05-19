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

    // Complete the hackerrankInString function below.
    //solved
    static string hackerrankInString(string s)
    {
        char[] text = "hackerrank".ToCharArray();
        int[] pre = new int[text.Length];

        int j = 0;
        for(int i = 0; i < pre.Length; i++)
        {
            for (; j < s.Length;j++)
            {
                if(s[j] == text[i])
                {
                    pre[i] = 1;
                    j++;
                    break;
                }
            }
        }

        if(pre.Any(x=>x == 0)){
            return "NO";
        }
        return "YES";
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int q = Convert.ToInt32(Console.ReadLine());

        //for (int qItr = 0; qItr < q; qItr++)
        //{
        //    string s = Console.ReadLine();

            string result = hackerrankInString("hackerank");

        //    textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();
    }
}
