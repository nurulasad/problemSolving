using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{

    public class Dijkstra
    {
        //https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm#Pseudocode

        //        function Dijkstra(Graph, source):
        // 2
        // 3      create vertex set Q
        // 4
        // 5      for each vertex v in Graph:             
        // 6          dist[v] ← INFINITY                  
        // 7          prev[v] ← UNDEFINED                 
        // 8          add v to Q                      
        //10      dist[source] ← 0                        
        //11      
        //12      while Q is not empty:
        //13          u ← vertex in Q with min dist[u]    
        //14                                              
        //15          remove u from Q 
        //16          
        //17          for each neighbor v of u:           // only v that are still in Q
        //18              alt ← dist[u] + length(u, v)
        //19              if alt<dist[v]:               
        //20                  dist[v] ← alt 
        //21                  prev[v] ← u 
        //22
        //23      return dist[], prev[]


        //public enum VState
        //{
        //    NotVisited,
        //    Visited,
        //    Complete
        //}

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
        public void FindMinimumCost(Vertex[] vertices, Vertex source)
        {

            //foreach vertex 
            //parent = null
            //dist = undefined
            //add t o q

            List<Vertex> q = new List<Vertex>();

            foreach (Vertex v in vertices)
            {
                if(v.Id == source.Id)
                {
                    v.Cost = 0;
                }
                q.Add(v);
            }

            while (q.Count > 0)
            {

                int id = GetMin(q);
                Vertex u = q.Where(x => x.Id == id).First();
                q.Remove(u);

                foreach (var edge in u.Edges)
                {
                    Vertex v = vertices.Where(x=>x.Id == edge.ToVertex).First();

                    if (u.Cost + edge.Cost < v.Cost)
                    {
                        v.Cost = u.Cost + edge.Cost;
                        v.Parent = u;
                    }
                }
               
            }
        }

    }


}
