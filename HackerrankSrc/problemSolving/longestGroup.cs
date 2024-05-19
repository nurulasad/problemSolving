using System.Collections.Generic;
using System.Linq;
using static Solution.BFS;

public class Solution
{

    public class BFS
    {

        //solved

        //base algorithm for connected cell
        // A function to check if a given cell (row, col) 
        // can be included in DFS 
        bool isSafe(Vertex[,] vertices, int row, int col)
        {
            int ROW = vertices.GetLength(0);
            int COL = vertices.GetLength(1);
            // row number is in range, column number is in 
            // range and value is 1 and not yet visited 
            return (row >= 0) && (row < ROW) &&
                   (col >= 0) && (col < COL) &&
                   (vertices[row, col].Value == 1 && !vertices[row, col].Visited);
        }

        // A utility function to do DFS for a 2D boolean 
        // matrix. It only considers the 8 neighbours as 
        // adjacent vertices 
        public void DFS(Vertex[,] vertices, int row, int col, ref int count)
        {
            // These arrays are used to get row and column 
            // numbers of 8 neighbours of a given cell 
            int[] rowNbr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colNbr = { -1, 0, 1, -1, 1, -1, 0, 1 };

            // Mark this cell as visited 
            vertices[row, col].Visited = true;

            // Recur for all connected neighbours 
            for (int k = 0; k < 8; ++k)
            {
                if (isSafe(vertices, row + rowNbr[k], col + colNbr[k]))
                {
                    // increment region length by one 
                    count++;
                    DFS(vertices, row + rowNbr[k], col + colNbr[k], ref count);
                }
                else
                {
                    int a = 0;
                }
            }
        }


        // The main function that returns largest  length region 
        // of a given boolean 2D matrix 
        public int LargestRegion(Vertex[,] vertices)
        {
            
            int ROW = vertices.GetLength(0);
            int COL = vertices.GetLength(1);

            int result = 0;
            for (int i = 0; i < ROW; ++i)
            {
                for (int j = 0; j < COL; ++j)
                {
   
                    if (vertices[i,j].Value == 1 && !vertices[i, j].Visited)
                    {
                        // not visited yet, so new region found 
                        int count = 1;
                        DFS(vertices, i, j, ref count);

                        // maximum region 
                        if(count > result)
                        {
                            result = count;
                        }
                    }
                }
            }
            return result;
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
    }

    static void Main(string[] args)
    {
        BFS bfs = new BFS();
        
        string[] rows = {
                         "1",
                         "1" };


        Vertex[,] vertices = new Vertex[rows.Length, rows[0].Length];
        for (int i = 0; i < rows.Length; i++)
        {
            for (int j = 0; j < rows[i].Length; j++)
            {
                Vertex v = new Vertex(rows[i][j] - '0');

                vertices[i, j] = v;
            }
        }

        int c = bfs.LargestRegion(vertices);


        var a = 0;
    }

   


}
