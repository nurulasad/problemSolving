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

    // Complete the angryProfessor function below.
    //solved
    static string angryProfessor(int k, int[] a)
    {
        bool cancelled = true;
        int count = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i] <= 0)
            {
                count++;
            }
            if(count >= k)
            {
                cancelled = false;
                break;
            }
        }

        if (cancelled)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int t = Convert.ToInt32(Console.ReadLine());

        //for (int tItr = 0; tItr < t; tItr++)
        //{
        //    string[] nk = Console.ReadLine().Split(' ');

        //    int n = Convert.ToInt32(nk[0]);

        //    int k = Convert.ToInt32(nk[1]);

        //    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        //    ;
        //    string result = angryProfessor(k, a);

        //    textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();

        int[] a = { -1, -3, 4, 2 };
           ;
        string result = angryProfessor(2, a);
    }
}
