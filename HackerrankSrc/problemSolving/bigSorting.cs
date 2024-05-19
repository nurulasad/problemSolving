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
using System.Linq;

class Solution
{

    // Complete the bigSorting function below.
    //solved
    static string[] bigSorting(string[] unsorted)
    {
        MyComparer mc = new MyComparer();
        Array.Sort(unsorted, mc);
        return unsorted;
    }

    public class MyComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == y)
                return 0;

            string s1 = (string)x;
            string s2 = (string)y;

            if (s1.Length < s2.Length)
                return -1;
            if (s1.Length > s2.Length)
                return 1;

            return StringCompareOfSameLength(s1, s2);
        }

        private int StringCompareOfSameLength(string s1, string s2)
        {
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i]-'0' > s2[i] - '0')
                {
                    return 1;
                }
                else if(s1[i] - '0' < s2[i] - '0')
                {
                    return -1;
                }
            }
            return 0;
        }


    }
    

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //string[] unsorted = new string[n];

        //for (int i = 0; i < n; i++)
        //{
        //    string unsortedItem = Console.ReadLine();
        //    unsorted[i] = unsortedItem;
        //}
        string[] unsorted = new string[] { "100","101","1"};

        string[] result = bigSorting(unsorted);

        //textWriter.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
