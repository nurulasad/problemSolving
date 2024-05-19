using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{

    //full solved
    static Dictionary<int, string> wordDict = new Dictionary<int, string>();


    static string timeInWords(int h, int m)
    {

        init();
        string s = "";
        if (m == 0)
        {
            s = wordDict[h] + " " + wordDict[m];
        }
        else
        {
            s = GetMinuteInWord(m) + " " + GetSubWord(m) + " " + GetHourInWord(m, h);
        }




        return s;

    }

    static string GetSubWord(int min)
    {
        if (min == 15 || min == 30)
            return "past";

        else if (min == 45)
            return "to";

        else if (min == 1)
            return "minute past";
        else if (min == 59)
            return "minute to";
        else if (min > 1 && min < 30)
            return "minutes past";
        else if (min > 30)
            return "minutes to";
        return "";
    }



    static string GetMinuteInWord(int min)
    {
        if (min <= 30)
            return wordDict[min];

        else return wordDict[60 - min];

    }


    static string GetHourInWord(int min, int h)
    {
        if (min <= 30)
            return wordDict[h];
        else if (h == 12)
            return wordDict[1];

        else return wordDict[h + 1];

    }

    static void init()
    {
        wordDict.Add(0, "o' clock");

        wordDict.Add(1, "one");
        wordDict.Add(2, "two");
        wordDict.Add(3, "three");
        wordDict.Add(4, "four");
        wordDict.Add(5, "five");

        wordDict.Add(6, "six");
        wordDict.Add(7, "seven");
        wordDict.Add(8, "eight");
        wordDict.Add(9, "nine");
        wordDict.Add(10, "ten");

        wordDict.Add(11, "eleven");
        wordDict.Add(12, "twelve");
        wordDict.Add(13, "thirteen");
        wordDict.Add(14, "fourteen");


        wordDict.Add(15, "quarter");


        wordDict.Add(16, "sixteen");
        wordDict.Add(17, "seventeen");
        wordDict.Add(18, "eighteen");
        wordDict.Add(19, "nineteen");
        wordDict.Add(20, "twenty");

        wordDict.Add(21, "twenty one");
        wordDict.Add(22, "twenty two");
        wordDict.Add(23, "twenty three");
        wordDict.Add(24, "twenty four");
        wordDict.Add(25, "twenty five");

        wordDict.Add(26, "twenty six");
        wordDict.Add(27, "twenty seven");
        wordDict.Add(28, "twenty eight");
        wordDict.Add(29, "twenty nine");

        wordDict.Add(30, "half");


    }


    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int h = Convert.ToInt32(Console.ReadLine());

        //int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(7, 29);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

