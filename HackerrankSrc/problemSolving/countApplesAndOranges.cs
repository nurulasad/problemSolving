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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int[] appleD = new int[apples.Length];
        int aCount = 0;
        int oCount = 0;

        int min, max;
        if (s > t)
        {
            max = s;
            min = t;
        }
        else
        {
            max = t;
            min = s;
        }

        for(int i = 0; i < apples.Length; i++)
        {
            int pos = a + apples[i];
            if(pos >= min && pos <= max)
            {
                aCount++;
            }
        }

        for (int i = 0; i < oranges.Length; i++)
        {
            int pos = a + oranges[i];
            if (pos >= min && pos <= max)
            {
                oCount++;
            }
        }


        Console.WriteLine(aCount);
        Console.WriteLine(oCount);
    }

    static void Main(string[] args)
    {
        //string[] st = Console.ReadLine().Split(' ');

        //int s = Convert.ToInt32(st[0]);

        //int t = Convert.ToInt32(st[1]);

        //string[] ab = Console.ReadLine().Split(' ');

        //int a = Convert.ToInt32(ab[0]);

        //int b = Convert.ToInt32(ab[1]);

        //string[] mn = Console.ReadLine().Split(' ');

        //int m = Convert.ToInt32(mn[0]);

        //int n = Convert.ToInt32(mn[1]);

        //int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        //;

        //int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        //;
        int[] apples = { -25,-15,-5};
        int[] oranges = {  };

        countApplesAndOranges(10, 20, 25, 35, apples, oranges);
    }
}
