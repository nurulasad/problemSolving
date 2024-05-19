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

    // Complete the strangeCounter function below.
    //timeout for 4 test cases
    static long strangeCounter(long t)
    {

        //long tlower = long.MinValue;
        //long vlower = 0;
        ////long tupper = long.MaxValue;
        //for(int i = 1; i < t + 2; i++)
        //{
        //    long vn = GetNthterm(i);
        //    long tn = vn - 2;
        //    if(tn > tlower && tn <= t)
        //    {
        //        tlower = tn;
        //        vlower = vn;
        //    }
        //    //if (tn < tupper && tn >= t)
        //    //{
        //    //    tupper = tn;
        //    //}
        //}

        //for(long i = tlower; i < t; i++)
        //{
        //    vlower--;
        //}

        //return vlower;


        long tlower = long.MinValue;
        long vlower = 0;
        //long tupper = long.MaxValue;
        //for (long i = t+2; i >1; i--)
        //{
            long vn = GetNthterm(t);
            long tn = vn - 2;
            if (tn > tlower && tn <= t)
            {
                tlower = tn;
                vlower = vn;
            }
            //if (tn < tupper && tn >= t)
            //{
            //    tupper = tn;
            //}
        //}

        for (long i = tlower; i < t; i++)
        {
            vlower--;
        }

        return vlower;

    }

    static long GetNthterm(long n)
    {
        var p = Math.Pow(2,n - 1);
        long value = 3 * (long)p;
        return value;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //long t = Convert.ToInt64(Console.ReadLine());

        long result = strangeCounter(15);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
