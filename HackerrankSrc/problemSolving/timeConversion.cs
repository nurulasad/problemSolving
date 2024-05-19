using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        /*
         * Write your code here.
         * Solved
         */

        //07:05:45PM

        string timesection = s.Replace("PM", "").Replace("AM", "");
        string[] segments = timesection.Split(':');

        int h = int.Parse(segments[0]);
        
        if(s.EndsWith("AM") && h ==12)
        {
            h = 0;
        }
        else if(s.EndsWith("PM") && h != 12)
        {
            h += 12;
        }



        string newHour = h.ToString();
        if(newHour.Length == 1)
        {
            newHour = "0" + newHour;
        }

        string militaryTime = $"{newHour}:{segments[1]}:{segments[2]}";

        return militaryTime;


    }

    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();

        string[] s = { "12:05:39AM", "07:05:45PM","00:00:00AM", "11:59:59PM", "12:00:00PM" };

        for(int i = 0; i < s.Length; i++)
        {
            string result = timeConversion(s[i]);
        }
        

        //tw.WriteLine(result);

        //tw.Flush();
        //tw.Close();
    }
}
