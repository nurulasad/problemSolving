﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution
{
    public static void insertionSort(int[] A)
    {
        //var j = 0;
        //for (var i = 1; i < A.Length; i++)
        //{
        //    var value = A[i];
        //    j = i - 1;
        //    while (j > 0 && value < A[j])
        //    {
        //        A[j + 1] = A[j];
        //        j = j - 1;
        //    }
        //    A[j + 1] = value;
        //}

        Array.Sort(A);
        Console.WriteLine(string.Join(" ", A));
    }

    static void Main(string[] args)
    {
        //Console.ReadLine();
        //int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();

        int[] _ar = new int[] { 3, 5, 8 };
        insertionSort(_ar);
    }
}

