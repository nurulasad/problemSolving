using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{
    public enum VertexColor
    {
        White,
        Gray,
        Black


    }
    public class Edge
    {
        public int ToVertex { get; set; }
        public int Cost { get; set; }
        public Edge(int vertex, int cost)
        {
            ToVertex = vertex;
            Cost = cost;
        }
        public Edge(int vertex)
        {
            ToVertex = vertex;
            Cost = 1;
        }
    }

    public class Vertex
    {

        public int Id { get; set; }

        //to vertex id, cost
        public List<Edge> Edges { get; set; }
        public Vertex Parent { get; set; }
        public int Cost { get; set; } = 1;
        public int FinishedTime { get; set; }
        public int Time { get; set; }

        public VertexColor Color { get; set; }

        public bool IsVisited = false;
        public bool IsCyclic = false;

        public Vertex(int id, List<Edge> edges = null)
        {
            Id = id;
            Edges = edges;
            Cost = int.MaxValue;

            if (edges == null)
            {
                Edges = new List<Edge>();
            }
        }

        public Vertex(int id, List<int> adjacenyList)
        {
            Id = id;;

            if (Edges == null)
            {
                Edges = new List<Edge>();
            }

            foreach (var edgeTo in adjacenyList)
            {
                var edge = new Edge(edgeTo);
                Edges.Add(edge);
            }
        }
    }
}
