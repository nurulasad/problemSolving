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

    // Complete the freqQuery function below.
    //partial soln, 4 test cases timed out
    //The discussion says it is due to the list data strcuture, a 2d array fix the issue

    static List<int> freqQuery(List<List<int>> queries)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();
        int index = 0;
        foreach(List<int> q in queries)
        {
            int operation = q[0];
            int key = q[1];
            if(operation == 1)
            {
                if (!map.ContainsKey(key))
                {
                    map.Add(key, 1);
                }
                else
                {
                    map[key] += 1;
                }
            }
            else if(operation == 2)
            {
                if (!map.ContainsKey(key))
                {
                    map.Add(key, 0);
                }
                else
                {
                    map[key] -= 1;
                    if(map[key] < 0)
                    {
                        map[key] = 0;
                    }
                }

            }
            else if(operation == 3)
            {
                int count  = map.Where(x => x.Value == key).Count();
                if(count > 0)
                {
                    result.Add(1);
                }
                else
                {
                    result.Add(0);
                }
                index++;

            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        List<int> ans = new List<int>();
        const Int32 BufferSize = 128;
        using (var fileStream = File.OpenRead("inputfreqQuery.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            int q = Convert.ToInt32(streamReader.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(streamReader.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            ans = freqQuery(queries);

            
        }
        List<int> expected = new List<int>();
        using (var fileStream = File.OpenRead("inputfreqQueryResult.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            string s = streamReader.ReadLine().Trim();
            while(!string.IsNullOrEmpty(s))
            {
                s = s.Trim();
                int q = Convert.ToInt32(s);
                expected.Add(q);

                s = streamReader.ReadLine();
            }

            

        }

        for(int i = 0; i < ans.Count; i++)
        {
            if(ans[i] != expected[i])
            {
                int m = ans[i];
                int k = expected[i];
            }
        }


    }
}
