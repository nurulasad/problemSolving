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

    // Complete the extraLongFactorials function below.
    //solved
    static void extraLongFactorials(int a)
    {
       
        string fac = a.ToString();
        for(int i = a-1; i > 0; i--)
        {
            fac = multiply(fac, i.ToString());
        }
        Console.WriteLine(fac);


    }

    static string multiply(string s1, string s2)
    {

        List<string> m = new List<string>();

        for (int i = s1.Length - 1; i >= 0; i--)
        {
            string ps = "";
            int rem = 0;
            for (int j = s2.Length - 1; j >= 0; j--)
            {
                int p = (s2[j] - '0') * (s1[i] - '0') + rem;
                rem = (p / 10);
                int divisor = p % 10;
                ps = divisor.ToString() + ps;
            }
            if (rem > 0)
            {
                ps = rem + ps;
            }
            for (int k = 0; k < s1.Length - 1 - i; k++)
            {
                ps = ps + "0";
            }
            m.Add(ps);
        }

        string partialSum = "0";
        for (int i = 0; i < m.Count; i++)
        {
            partialSum = sum(partialSum, m[i]);
        }

        return partialSum;


    }

    static string sum(string a, string b)
    {
        //fillup length with zero
        if(a.Length < b.Length)
        {
            for(int i = 0; i <= b.Length - a.Length; i++)
            {
                a = "0" + a;
            }
        }
        else if(b.Length < a.Length)
        {
            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                b = "0" + b;
            }
        }

        //now sum up
        int rem = 0;
        string ps = "";
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int p = (a[i] - '0') + (b[i]-'0') + rem;
            rem = (p / 10);
            int divisor = p % 10;
            ps = divisor.ToString() + ps;

        }
        if (rem > 0)
        {
            ps = rem + ps;
        }
        return ps;
    }

    static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(25);
    }
}
