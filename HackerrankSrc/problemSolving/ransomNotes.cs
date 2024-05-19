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

class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {

Dictionary<string, int> map = new Dictionary<string, int>();

        bool hasMissing = false;
        foreach(string n in note)
        {
            if (!map.ContainsKey(n))
            {
                map.Add(n, 1);
                
            }
            else
            {
                map[n] += 1;
            }
            
        }

        foreach (string m in magazine)
        {
            if (map.ContainsKey(m))
            {
                map[m] -= 1;
            }
        }

        foreach (var m in map)
        {
            if(m.Value > 0)
            {
                hasMissing = true;
                break;
            }
        }

        if (hasMissing)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
