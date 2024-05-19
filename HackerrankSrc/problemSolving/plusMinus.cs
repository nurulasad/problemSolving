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

    // Complete the plusMinus function below.
    //Solved
    static void plusMinus(int[] arr)
    {
        int pos, neg, zero;
        pos = neg = zero = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                pos++;
            }
            else if(arr[i] < 0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
        }



        float rp = (float)pos / arr.Length;
        float rn = (float)neg / arr.Length;
        float rz = (float)zero / arr.Length;

        Console.WriteLine(rp);
        Console.WriteLine(rn);
        Console.WriteLine(rz);



    }

    static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //;

        int[] arr = new int[5] { 1, 1, 0, -1, -1 };
        plusMinus(arr);
    }
}
