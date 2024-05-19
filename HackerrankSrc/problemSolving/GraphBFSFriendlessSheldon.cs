using System.Collections.Generic;
using System.Linq;
//using static Solution.BFS;

public class Solution2
{

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

            return id;

        }
        public void Traverse(Vertex[] vertices, Vertex root)
        {

            //foreach vertex 
            //parent = null
            //dist = undefined
            //add t o q

            List<Vertex> q = new List<Vertex>();

            foreach (Vertex v in vertices)
            {
                q.Add(v);
            }

            while (q.Count > 0)
            {

                int id = GetMin(q);
                if (id < 0)
                    break;
               
                Vertex v = q.Where(x => x.Id == id).First();
                q.Remove(v);

                for (int i = 0; i < v.Edges.GetLength(0); i++)
                {
                    Vertex w = vertices[v.Edges[i, 0]];

                    if (v.Cost + v.Edges[i, 1] < w.Cost)
                    {
                        w.Cost = v.Cost + v.Edges[i, 1];
                        w.Parent = v;
                    }
                }
            }
        }


        public class Vertex
        {

            public int Id { get; set; }

            //to vertex id, cost
            public int[,] Edges { get; set; }
            public Vertex Parent { get; set; }
            public int Cost { get; set; }

            public Vertex(int id, int[,] edges)
            {
                Id = id;
                Edges = edges;
                Cost = int.MaxValue;
            }
        }

        static void Main(string[] args)
        {
            BFS bfs = new BFS();

            Vertex v1 = new Vertex(1, new int[,] { { 1, 1 }, { 3, 10 } });
            Vertex v2 = new Vertex(2, new int[,] { { 2, 1 } });
            Vertex v3 = new Vertex(3, new int[,] { { 4,1} });
            Vertex v4 = new Vertex(4, new int[,] { { 4, 1 } });
            Vertex v5 = new Vertex(5, new int[,] { });

            v1.Cost = 0;
            List<Vertex> vertices = new List<Vertex>() { v1, v2, v3, v4, v5};
            bfs.Traverse(vertices.ToArray(), v1);

            var a = vertices[4].Cost;
        }
    }

    
}
