using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{

    /*
     * Complete solve
     * 
     * 
     */
    public class BFS
    {


        private int GetMin(List<Vertex> vertices)
        {
            int minCost = int.MaxValue;
            int id = -1;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].Cost < minCost)
                {
                    minCost = vertices[i].Cost;
                    id = vertices[i].Id;
                }
            }
            if (id == -1)
            {
                Vertex v = vertices.FirstOrDefault();
                if (v != null)
                {
                    id = v.Id;
                }
            }


            return id;

        }
        public void Traverse(Vertex[] vertices, Vertex root)
        {

            List<Vertex> q = new List<Vertex>();

            foreach (Vertex v in vertices)
            {
                q.Add(v);
            }

            while (q.Count > 0)
            {

                int id = GetMin(q);
                Vertex v = q.Where(x => x.Id == id).First();
                q.Remove(v);

                for (int i = 0; i < v.Edges.Count(); i++)
                {
                    Vertex w = vertices[v.Edges.ElementAt(i)[0]];

                    int newCost = int.MaxValue;
                    try
                    {
                        newCost = checked(v.Cost + v.Edges.ElementAt(i)[1]);
                    }
                    catch (OverflowException)
                    {
                        //                        newCost = int.MaxValue;
                        //Console.WriteLine("overflow for i = " + i);
                    }

                    if (newCost < w.Cost)
                    {
                        w.Cost = newCost;
                        w.Parent = v;
                    }
                }
            }
        }



    }
    public class Vertex
    {

        public int Id { get; set; }

        //to vertex id, cost
        public List<int[]> Edges { get; set; }
        public Vertex Parent { get; set; }
        public int Cost { get; set; }

        public Vertex(int id, List<int[]> edges)
        {
            Id = id;
            Edges = edges;
            Cost = int.MaxValue;
        }
        public Vertex(int id)
        {
            Id = id;
            Cost = int.MaxValue;
            Edges = new List<int[]>();
        }
    }

    // Complete the bfs function below.


    static int HasJumper(int[][] jumpers,int pos)
    {
        for (int i = 0; i < jumpers.GetLength(0); i++)
        {
            if(jumpers[i][0] - 1 == pos)
            {
                return i;
            }
        }
        return -1;
    }

    
    static void AddEdge(Vertex vertex, int[][] ladders, int[][] snakes, int index, int jumpCount)
    {
        if (HasJumper(ladders, index) > -1)
        {
            int ladderIndex = HasJumper(ladders, index);
            if(vertex.Edges.Any(x=>x[0] == ladders[ladderIndex][1] - 1))
            {
                return;
            }
            vertex.Edges.Add(new int[] { ladders[ladderIndex][1] - 1, 0 });
        }
        else if (HasJumper(snakes, index) > -1)
        {
            int snakeIndex = HasJumper(snakes, index);
            vertex.Edges.Add(new int[] { snakes[snakeIndex][1] - 1, 0 });
        }
        else
        {
            vertex.Edges.Add(new int[] { index + jumpCount, 1 });
        }
    }
    
    static int quickestWayUp(int[][] ladders, int[][] snakes)
    {
        int n = 100;
        Vertex[] vertices = new Vertex[n];

        for (int i = 0; i < n; i++)
        {
            vertices[i] = new Vertex(i);

            if (i < n - 1)
            {
                AddEdge(vertices[i], ladders, snakes, i, 1);
            }
            if (i < n - 2)
            {
                AddEdge(vertices[i], ladders, snakes, i, 2);
            }
            if (i < n - 3)
            {
                AddEdge(vertices[i], ladders, snakes, i, 3);
            }
            if (i < n - 4)
            {
                AddEdge(vertices[i], ladders, snakes, i, 4);
            }
            if (i < n - 5)
            {
                AddEdge(vertices[i], ladders, snakes, i, 5);
            }
            if (i < n - 6)
            {
                AddEdge(vertices[i], ladders, snakes, i, 6);
            }
        }
        
        BFS fS = new BFS();
        vertices[0].Cost = 0;
        fS.Traverse(vertices, vertices[0]);


        Vertex final = vertices[99];


        List<int[]> solPath = new List<int[]>();


        while (final.Parent != null)
        {
            solPath.Add(new int[] { final.Parent.Id, final.Id });

            final = final.Parent;

        }

        solPath.Reverse();

        int cost = vertices[99].Cost;

        if (cost == int.MaxValue)
        {
            return -1;
        }
        
        return cost;
    }




    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        const Int32 BufferSize = 128;
        using (var fileStream = File.OpenRead("inputsnakeLadder.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            int t = Convert.ToInt32(streamReader.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(streamReader.ReadLine());

                int[][] ladders = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    ladders[i] = Array.ConvertAll(streamReader.ReadLine().Split(' '), laddersTemp => Convert.ToInt32(laddersTemp));
                }

                int m = Convert.ToInt32(streamReader.ReadLine());

                int[][] snakes = new int[m][];

                for (int i = 0; i < m; i++)
                {
                    snakes[i] = Array.ConvertAll(streamReader.ReadLine().Split(' '), snakesTemp => Convert.ToInt32(snakesTemp));
                }

                int result = quickestWayUp(ladders, snakes);

                //textWriter.WriteLine(result);
            }

        }




    }
}

