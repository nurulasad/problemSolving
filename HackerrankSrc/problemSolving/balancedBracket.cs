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

    // Complete the isBalanced function below.
    //Solved
    static string isBalanced(string s)
    {

        Stack stack = new Stack();
        char[] tokens = s.ToCharArray();

        bool allPairFound = true;
        for (int j = 0; j < tokens.Length; j++)
        {
            if (tokens[j] == '[' || tokens[j] == '{' || tokens[j] == '(')
            {
                stack.Push(tokens[j]);
            }
            else
            {
                char rightToken = tokens[j];

                if (stack.Count == 0)
                {
                    allPairFound = false;
                    break;
                }
                char leftToken = (char)stack.Pop();

                allPairFound = IsPair(leftToken, rightToken);
                if (!allPairFound)
                {
                    break;
                }
            }

        }

        if(stack.Count != 0)
        {
            allPairFound = false;
        }
        if (allPairFound)
        {
            return "YES";
        }
        return "NO";
    }

    static bool IsPair(char a, char b)
    {
        if (a == '[' && b == ']')
            return true;
        if (a == '{' && b == '}')
            return true;
        if (a == '(' && b == ')')
            return true;

        return false;
    }
    static void Main(string[] args)
    {
        const Int32 BufferSize = 128;

        
        List<string> expectedOutputs = new List<string>();
        using (var fileStream = File.OpenRead("outputIsBalanced.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            {
                string res = "1";

                while(!string.IsNullOrEmpty(res))
                {
                    res = streamReader.ReadLine();
                    expectedOutputs.Add(res);
                }
                
            }

        }


        using (var fileStream = File.OpenRead("inputIsBalanced.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            {
                int t = Convert.ToInt32(streamReader.ReadLine());

                for (int tItr = 0; tItr < t; tItr++)
                {
                    string s = streamReader.ReadLine();

                    string result = isBalanced(s);
                    if(result != expectedOutputs.ElementAt(tItr))
                    {
                        var a = 0;
                    }
                    
                }

            }
            
        }
    }
}