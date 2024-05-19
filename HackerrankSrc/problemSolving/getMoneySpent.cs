using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     * solved
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int maxSpent = -1;
        for(int i = 0; i< keyboards.Length; i++)
        {
            for(int j = 0; j < drives.Length; j++)
            {
                int curSpent = keyboards[i] + drives[j];
                if (curSpent <= b && curSpent > maxSpent)
                {
                    maxSpent = curSpent;
                }
            }
        }

        return maxSpent;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] bnm = Console.ReadLine().Split(' ');

        //int b = Convert.ToInt32(bnm[0]);

        //int n = Convert.ToInt32(bnm[1]);

        //int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = new int[] { 1, 5, 9};

        int[] drives = new int[] { 20, 40, 50 };
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, 57);

        //textWriter.WriteLine(moneySpent);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
