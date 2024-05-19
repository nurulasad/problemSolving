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

    // Complete the climbingLeaderboard function below.
    //brute force, timed out for long
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        int[] newScores = new Int32[scores.Length + 1];
        int[] aliceRanks = new Int32[alice.Length];
        int[] rankPos = new int[2];

        for (int j = 0; j < scores.Length; j++)
        {
            newScores[j] = scores[j];
        }
        newScores[newScores.Length - 1] = alice[0];
        Array.Sort(newScores);
        Array.Reverse(newScores);
        rankPos = GetRank(newScores, alice[0]);
        aliceRanks[0] = rankPos[0];

        //List<int> newSc = newScores.ToList();
        int prevPos = rankPos[1];
        for (int i = 1; i < alice.Length; i++)
        {
            
            newScores[prevPos] = -1;

            Climb(newScores, prevPos, alice[i]);
           
            
            rankPos = GetRank(newScores, alice[i]);
            aliceRanks[i] = rankPos[0];
            prevPos = rankPos[1];
        }

        
        return aliceRanks;

    }


    static int[] Climb(int[] newScores, int prevPos, int currentScore)
    {
        int newPos = 0;
        for (int i = prevPos; i > 0; i--)
        {
            if (currentScore <= newScores[i-1])
            {
                newPos = i;
                break;
            }
            
        }

        for (int k = prevPos; k > newPos; k--)
        {

            newScores[k] = newScores[k - 1];
            newScores[k - 1] = -1;
        }

        newScores[newPos] = currentScore;

        return newScores;
    }

   

    static int[] GetRank(int[] a, int aliceScore)
    {
        int rank = 1;
        int position = -1;
        int prev = a[0];
        if (a[0] == aliceScore)
        {
            position = 0;
            a[0] = aliceScore;
            return new int[2] {rank, position };
        }
            

        for (int i = 1; i < a.Length; i++)
        {
            position = i;
            if (a[i] < prev)
            {
                rank++;
                prev = a[i];
            }
           

            if (a[i] == aliceScore)
            {
                a[i] = aliceScore;
                return new int[2] { rank, i };
            }



        }
        a[position] = aliceScore;
        return new int[2] { rank, position };


    }


    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = 7;// Convert.ToInt32(Console.ReadLine());
                            //        7
                            //100 100 50 40 40 20 10
                            //4
                            //5 25 50 120

        //int[] scores = new[] { 100, 100 ,50, 40,40, 20, 10 };// Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        int[] scores = new[] { 100, 90, 90, 80, 75, 60 };// Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        scores = new[]{ 997, 988, 981, 966, 957, 937, 933, 930, 929, 928, 927, 926, 922, 920, 916, 915, 903, 896, 887, 874, 872,866,
            863,863,860,859,858,857,857,847,847,842,830,819,815,809,803,797,796,794,794,789,785,783,778,772,765,765,764,757,755,751,
744,740,737,733,730,730,724,716,710,709,691,690,684,677,676,653,652,650,625,620,619,602,587,587,585,583,571,568,568,556,
552,546,541,540,538,531,530,529,527,506,504,501,498,493,493,492,489,482,475,468,457,452,445,442,441,438,435,435,433,430,
429,427,422,422,414,408,404,400,396,394,387,384,380,379,374,371,369,369,369,368,366,365,363,354,351,341,337,336,328,325,
318,316,314,307,306,302,287,282,281,277,276,271,246,238,236,230,229,229,228,227,220,212,199,194,179,173,171,168,150,144,
136,125,125,124,122,118,98,98,95,92,88,85,70,68,61,60,59,44,43,35,32,30,28,23,20,13,12,12};

        //int aliceCount = 4; // Convert.ToInt32(Console.ReadLine());

        //int[] alice = new[] { 5, 25, 50, 120 }; // Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        int[] alice = new[] { 50,65,77,90,102 }; // Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        alice = new[] {
            83,129,140,184,198,300,312,325,341,344,349,356,370,405,423,444,465,471,491,500,506,508,539,543,569,591,607,612,614,623,645,
670,689,726,744,747,764,773,777,787,805,811,819,829,841,905,918,918,955,997 };

        int[] result = climbingLeaderboard(scores, alice);

        int[] expected = new int[] { 169,
160,
159,
153,
152,
136,
133,
129,
125,
125,
125,
123,
118,
108,
105,
97,
94,
93,
90,
87,
84,
84,
79,
77,
73,
69,
68,
68,
68,
66,
65,
62,
59,
53,
48,
48,
44,
42,
42,
39,
34,
33,
31,
31,
30,
17,
15,
15,
6,
1};
        //textWriter.WriteLine(string.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
