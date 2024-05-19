using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the gradingStudents function below.
     * solved
     */
    static int[] gradingStudents(int[] grades)
    {
        int[] finalGrade = new int[grades.Length];
        for(int i = 0; i < grades.Length; i++)
        {
            if(grades[i] < 38)
            {
                finalGrade[i] = grades[i];
            }

            else if(grades[i]%5 > 2)
            {
                finalGrade[i] = grades[i]+ 5 - (grades[i] % 5);
            }
            else
            {
                finalGrade[i] = grades[i];
            }
        }

        return finalGrade;

    }

    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] grades = new int[n];

        //for (int gradesItr = 0; gradesItr < n; gradesItr++)
        //{
        //    int gradesItem = Convert.ToInt32(Console.ReadLine());
        //    grades[gradesItr] = gradesItem;
        //}

        int[] grades = { 35, 38, 42, 45, 46, 47 };
        int[] result = gradingStudents(grades);

        //tw.WriteLine(string.Join("\n", result));

        //tw.Flush();
        //tw.Close();
    }
}
