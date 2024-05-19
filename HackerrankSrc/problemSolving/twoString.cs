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

    // Complete the twoStrings function below.
    //solved
    static string twoStrings(string s1, string s2)
    {

        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < s1.Length; i++)
        {
            if (!map.ContainsKey(s1[i]))
            {
                map.Add(s1[i], 1);
            }
        }

        bool hasCommon = s2.Any(x => map.ContainsKey(x) && map[x] > 0);

        if (hasCommon)
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
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
