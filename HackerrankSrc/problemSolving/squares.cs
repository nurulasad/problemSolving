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

    // Complete the squares function below.
    //solved
    static int squares(int a, int b)
    {
        /* Brute force , timed out 
        int count = 0;
        for(int i = a; i <= b; i++)
        {
            double d = Math.Sqrt(i);
            if(d == Math.Floor(d))
            {
                count++;
            }
        }

        return count;
        */

        //optimized

        int count =  (int)(Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(a)) + 1);
        return count;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int q = Convert.ToInt32(Console.ReadLine());

        //for (int qItr = 0; qItr < q; qItr++)
        //{
        //    string[] ab = Console.ReadLine().Split(' ');

        //    int a = Convert.ToInt32(ab[0]);

        //    int b = Convert.ToInt32(ab[1]);

            int result = squares(1, 20);

        //    textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();
    }
}
