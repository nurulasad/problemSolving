using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{

    /*
     * Solved
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
    static int[] bfs(int n, int m, int[][] edges, int s)
    {
        Vertex[] vertices = new Vertex[n];

        for (int i = 0; i < n; i++)
        {
            vertices[i] = new Vertex(i);

        }

        int edgeCount = m;

        for (int i = 0; i < edgeCount; i++)
        {

            int fromVId = edges[i][0] - 1;
            int toVId = edges[i][1] - 1;

            int[] edge = new int[2] { toVId, 6 };

            vertices[fromVId].Edges.Add(edge);

            //othewise mises the link in other order
            int[] edge2 = new int[2] { fromVId, 6 };
            vertices[toVId].Edges.Add(edge2);


        }

        BFS bfs = new BFS();
        vertices[s - 1].Cost = 0;

        bfs.Traverse(vertices, vertices[s - 1]);

        List<int> costs = new List<int>();
        for (int i = 0; i < vertices.Length; i++)
        {
            if (vertices[i].Cost == int.MaxValue)
            {
                costs.Add(-1);
            }
            else if (vertices[i].Cost > 0)
            {
                costs.Add(vertices[i].Cost);
            }

        }
        return costs.ToArray();

    }


    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        const Int32 BufferSize = 128;
        using (var fileStream = File.OpenRead("input04.txt"))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
        {
            int q = Convert.ToInt32(streamReader.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] nm = streamReader.ReadLine().Split(' ');

                int n = Convert.ToInt32(nm[0]);

                int m = Convert.ToInt32(nm[1]);

                int[][] edges = new int[m][];

                for (int i = 0; i < m; i++)
                {
                    edges[i] = Array.ConvertAll(streamReader.ReadLine().Split(' '), edgesTemp => Convert.ToInt32(edgesTemp));
                }

                int s = Convert.ToInt32(streamReader.ReadLine());

                int[] result = bfs(n, m, edges, s);

                //textWriter.WriteLine(string.Join(" ", result));
            }

            //textWriter.Flush();
            //textWriter.Close();

        }

        


    }
}

