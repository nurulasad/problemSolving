using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{

    public class Prim
    {
        /* 
         * 
         * https://en.wikipedia.org/wiki/Prim%27s_algorithm
         * https://www.geeksforgeeks.org/prims-minimum-spanning-tree-mst-greedy-algo-5/
         * 
         * Minimum spanning tree
         * 
         * Follow the given steps to find MST using Prim’s Algorithm:
Create a set mstSet that keeps track of vertices already included in MST. 
Assign a key value to all vertices in the input graph. Initialize all key values as INFINITE. Assign the key value as 0 for the first vertex so that it is picked first. 
While mstSet doesn’t include all vertices 
Pick a vertex u which is not there in mstSet and has a minimum key value. 
Include u in the mstSet. 
Update the key value of all adjacent vertices of u. To update the key values, iterate through all adjacent vertices. For every adjacent vertex v, if the weight of edge u-v is less than the previous key value of v, update the key value as the weight of u-v
        */

        private Vertex GetMin(List<Vertex> vertices, List<Vertex> mstSet)
        {
            //this is not generating correct MST , check with https://www.geeksforgeeks.org/prims-minimum-spanning-tree-mst-greedy-algo-5/
            int minCost = int.MaxValue;
            Vertex selectedVertex = null;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (mstSet.Any(x => x.Id == vertices[i].Id))
                {
                    //it is already included in the msset
                    continue;
                }

                if (vertices[i].Cost < minCost)
                {
                    minCost = vertices[i].Cost;
                    selectedVertex = vertices[i];
                }
            }

            return selectedVertex;

        }

        private Vertex CloneVertex(Vertex vertex)
        {
           

            Vertex clonedVertex = new Vertex(vertex.Id);
            return clonedVertex;

        }

        public List<Vertex>  PrimMST(List<Vertex> graph, Vertex root)
        {

            // Array to store constructed MST
            //List<Vertex> parent = new int[V];

            // Key values used to pick
            // minimum weight edge in cut
            //int[] key = new int[V];

            // To represent set of vertices
            // included in MST
            List<Vertex> mstSet = new List<Vertex>();

            // Initialize all keys
            // as INFINITE
            foreach (Vertex v in graph)
            {
                v.IsVisited = false;
                v.Cost = int.MaxValue;
                v.Parent = null;
            }

            // Always include first 1st vertex in MST.
            // Make key 0 so that this vertex is
            // picked as first vertex
            // First node is always root of MST

            root.Cost = 0;

            // The MST will have V vertices
            for (int count = 0; count < graph.Count - 1; count++)
            {

                // Pick the minimum key vertex
                // from the set of vertices
                // not yet included in MST
                var u = GetMin(graph, mstSet);

                // Add the picked vertex
                // to the MST Set
                var uClone = CloneVertex(u);
                mstSet.Add(uClone);

                // Update key value and parent
                // index of the adjacent vertices
                // of the picked vertex. Consider
                // only those vertices which are
                // not yet included in MST
                foreach (var edge in u.Edges)

                    // graph[u][v] is non zero only
                    // for adjacent vertices of m
                    // mstSet[v] is false for vertices
                    // not yet included in MST Update
                    // the key only if graph[u][v] is
                    // smaller than key[v]

                    if (!mstSet.Any(x => x.Id == edge.ToVertex))
                    {
                        Vertex v = graph.Where(x => x.Id == edge.ToVertex).FirstOrDefault();
                        if (edge.Cost < v.Cost)
                        {
                            v.Parent = u;
                            v.Cost = edge.Cost;
                            uClone.Edges.Add(new Edge(v.Id, edge.Cost));
                        }
                    }

            }

            return mstSet;

        }



    }



}
