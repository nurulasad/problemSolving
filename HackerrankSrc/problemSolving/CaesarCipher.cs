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

    // Complete the caesarCipher function below.
    //solved
    static string caesarCipher(string s, int k)
    {
        char[] chs = s.ToCharArray();

        for (int i = 0; i < chs.Length; i++)
        {
            char c = chs[i];
            char intialLetter = 'a';
            int newc = c;
            if (char.IsLetter(c))
            {
                if (!char.IsLower(c))
                {
                    intialLetter = 'A';
                }

                newc = (chs[i] - intialLetter + k) % 26;
                chs[i] = (char) (newc+ intialLetter);

            }
        }

        return new string(chs);

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //string s = Console.ReadLine();

        //int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher("middle-Outz", 2);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
