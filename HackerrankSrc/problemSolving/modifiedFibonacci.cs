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

    // Complete the fibonacciModified function below.
    //times out drastically, 50% test cases fails

    static Dictionary<int, string> store = new Dictionary<int, string>();
    static Dictionary<int, string> square = new Dictionary<int, string>();
    static string fibonacciModified(int t1, int t2, int n)
    {
        string tn = fib2(t1.ToString(), t2.ToString(), n);
        return tn;
    }


    static string fib2(string t1, string t2, int n)
    {
        if (n == 1)
            return t1.ToString();
        if (n == 2)
            return t2.ToString();

        if (store.ContainsKey(n))
        {
            return store[n];
        }

        string ti = fib2(t1, t2, n - 2);

        string pre = "";
        if (square.ContainsKey(n - 2))
        {
            pre = square[n - 2];
        }
        else
        {
            pre = multiply(ti.ToString(), ti.ToString());
            square.Add(n - 2, pre);
        }



        string ti2 = fib2(t1, t2, n - 1);
        string s = "";
        if (square.ContainsKey(n - 1))
        {
            s = square[n - 1];
        }
        else
        {
            s = multiply(ti2.ToString(), ti2.ToString());
            square.Add(n - 1, s);
        }

        
        string s2 = sum(ti.ToString(), s);

        //double fn = fib2(t1, t2, n - 2) + fib2(t1, t2, n - 1) * fib2(t1, t2, n - 1);

        store.Add(n, s2);
        return s2;

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
        int alen = a.Length;
        int blen = b.Length;

        if (alen < blen)
        {
            for (int i = 0; i < blen - alen; i++)
            {
                a = "0" + a;
            }
        }
        else if (blen < alen)
        {
            for (int i = 0; i < alen - blen; i++)
            {
                b = "0" + b;
            }
        }

        //now sum up
        int rem = 0;
        string ps = "";
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int p = (a[i] - '0') + (b[i] - '0') + rem;
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
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] t1T2n = Console.ReadLine().Split(' ');

        //int t1 = Convert.ToInt32(t1T2n[0]);

        //int t2 = Convert.ToInt32(t1T2n[1]);

        //int n = Convert.ToInt32(t1T2n[2]);

        string result = fibonacciModified(1, 2, 20);
        //expected = 84266613096281243382112

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
