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


    public class BFS
    {

        //base algorithm for connected cell
  
        bool isSafe(Vertex[,] vertices, int row, int col)
        {
            int ROW = vertices.GetLength(0);
            int COL = vertices.GetLength(1);
        
            return (row >= 0) && (row < ROW) &&
                   (col >= 0) && (col < COL) &&
                   (vertices[row, col].Value == 1 && !vertices[row, col].Visited);
        }

        
        public void DFS(Vertex[,] vertices, int row, int col, ref int count)
        {
           
            int[] rowToTraverse = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colToTraverse = { -1, 0, 1, -1, 1, -1, 0, 1 };

            vertices[row, col].Visited = true;

            //for all connected neighbours 
            for (int k = 0; k < 8; ++k)
            {
                if (isSafe(vertices, row + rowToTraverse[k], col + colToTraverse[k]))
                {
                    count++;
                    DFS(vertices, row + rowToTraverse[k], col + colToTraverse[k], ref count);
                }
                //else
                //{
                //    int a = 0;
                //}
            }
        }

        public int LargestRegion(Vertex[,] vertices)
        {

            int ROW = vertices.GetLength(0);
            int COL = vertices.GetLength(1);

            int result = 0;
            for (int i = 0; i < ROW; ++i)
            {
                for (int j = 0; j < COL; ++j)
                {

                    if (vertices[i, j].Value == 1 && !vertices[i, j].Visited)
                    {
                        // not visited yet, so new region found 
                        int count = 1;
                        DFS(vertices, i, j, ref count);

                        // maximum region 
                        if (count > result)
                        {
                            result = count;
                        }
                    }
                }
            }
            return result;
        }
        
    }
    public class Vertex
    {

        public int Value { get; set; }
        public bool Visited { get; set; }

        public Vertex(int value)
        {
            Value = value;
        }
    }

    // Complete the connectedCell function below.
    static int connectedCell(int[][] matrix)
    {
        int ROW = matrix.GetLength(0);
        int COL = matrix[0].Length;
        Vertex[,] vertices = new Vertex[ROW, COL];
        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                Vertex v = new Vertex(matrix[i][j]);

                vertices[i, j] = v;
            }
        }

        BFS bfs = new BFS();
        int count = bfs.LargestRegion(vertices);
        return count;



    }


    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int m = Convert.ToInt32(Console.ReadLine());

        int[][] matrix = new int[1][];
        matrix[0] = new int[1] { 1};

        //for (int i = 0; i < n; i++)
        //{
        //    matrix[i] = Array.ConvertAll(Console.ReadLine().Split(' '), matrixTemp => Convert.ToInt32(matrixTemp));
        //}

        int result = connectedCell(matrix);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
