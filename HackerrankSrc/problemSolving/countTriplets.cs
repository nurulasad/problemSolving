using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution {

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r) {

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                bool hasRatio = HasRatio(arr[i], arr[j], r);
                if (hasRatio)
                {
                    var key = AddCount(i, j);
                }
            }
        }

        var count = 0;
        foreach (var item in Triplets)
        {
            count += item.Value.Count;
        }

        return count;
    }

    private static Dictionary<int[], List<int>> Triplets = new Dictionary<int[], List<int>>();

    private static bool HasRatio(long a, long b, long r)
    {
        if (b / a == r) 
            return true;
        return false;
    }

    private static int[] AddCount(int s, int e)
    {
        var key = new int[2] { s, e };

        //search keys that ends with s to add the triplet set
        foreach(var item in Triplets)
        {
            if(item.Key[1] == s)
            {
                item.Value.Add(e);
            }
        }

        //and add the pair in dictionary for future pair search
        if (!Triplets.ContainsKey(key))
        {
            Triplets.Add(key, new List<int>());
        }
      
        return key;

    }

   
 

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var lines = File.ReadLines("input.txt").ToList();

        //

        string[] nr = lines[0].TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = lines[1].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        //textWriter.WriteLine(ans);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
