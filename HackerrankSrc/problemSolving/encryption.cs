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

    // Complete the encryption function below.
    static string encryption(string s)
    {

        s = s.Trim();
        s = s.Replace(" ", "");

        var len = s.Length;

        var sqrt = Math.Sqrt((double)len);

        var rows = Math.Floor(sqrt);
        var cols = Math.Ceiling(sqrt);

        if(rows*cols < len)
        {
            rows += 1;
        }

        string[] grid = new string[(int)rows];


        for(int i = 0, row = 0; i< s.Length; i = i+(int)cols, row++)
        {
            if(i+ cols > s.Length)
            {
                grid[row] = s.Substring(i);
            }
            else
            {
                grid[row] = s.Substring(i, (int)cols);
            }
            
        }

        var display = string.Empty;

        for( int i = 0; i < cols; i++)
        {
            for(int j = 0; j< rows && j < grid.Length; j++)
            {
                if (i >= grid[j].Length)
                    continue;

                display += grid[j][i];
            }
            display += " ";
        }


        display = display.Trim();
        
        return display;
       

        

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();

        string result = encryption("chillout"); // if man was meant to stay on the ground god would have given us roots");

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
