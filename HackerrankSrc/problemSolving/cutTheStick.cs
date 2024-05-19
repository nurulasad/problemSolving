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

    // Complete the cutTheSticks function below.
    //solved
    static int[] cutTheSticks(int[] arr)
    {

        int min = 0;
        int count = arr.Where(x => x > 0).Count();

        List<int> countSteps = new List<int>() { count};

        while(count > 0)
        {
            min = arr.Where(x => x > 0).Min();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    arr[i] = arr[i] - min;
                }
                
            }
            count = arr.Where(x => x > 0).Count();
            if(count > 0)
            {
                countSteps.Add(count);
            }
            
            
        }

        return countSteps.ToArray();
        
    }

 

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[] { 5, 4, 4, 2, 2, 8 };
        
        int[] result = cutTheSticks(arr);

        //textWriter.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
