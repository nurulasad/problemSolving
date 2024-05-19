using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{

    public class GraphTravesrsal
    {
        /*https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/
         * https://en.wikipedia.org/wiki/Depth-first_search#Pseudocode
         * 
         * https://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode
         * 
         * sample:
         * 
         *  (1)
         *   |
         *  (2)
         *   |\\
         *   | |\ 
         *  (3)| \(10)
         *   |\ \   |\
         *   | \ |  | \
         *  (4) \\  |   \
         *       \| |   (20)
         *       (30)
         * 
         * 
         * BFS traverse > 1-> 2->3->10->30->4->20
         * DFS traverse-> 1->2->30->10->20->3->4
         *
         */


        public void Initialize(List<Vertex> vertices) {

            foreach (var vertex in vertices) { 
                vertex.IsVisited = false;
                vertex.Parent = null;
            }
        }
        public List<Vertex> TraverseBFS(List<Vertex> vertices, Vertex src)
        {
            List<Vertex> traversalOrder = new List<Vertex>();
            Queue<Vertex> q = new Queue<Vertex>();

            src.IsVisited = true;
            q.Enqueue(src);

            while (q.Count > 0)
            {

                var u = q.Dequeue();
                traversalOrder.Add(u);

                var adjacentList = u.Edges;

                foreach(var adjacent in adjacentList)
                {
                    var v = vertices.First(x => x.Id == adjacent.ToVertex); //no guarantee index will match the vertexId

                    if (!v.IsVisited)
                    {
                        v.IsVisited = true;
                        v.Parent = u;
                        q.Enqueue(v);
                    }
                }                
            }

            return traversalOrder;
        }

        public List<Vertex> TraverseDFS_Iterative(List<Vertex> vertices, Vertex src)
        {
            List<Vertex> traversalOrder = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();

            src.IsVisited = true;
            stack.Push(src);

            while (stack.Count > 0)
            {

                var u = stack.Pop();
                traversalOrder.Add(u);

                var adjacentList = u.Edges;

                foreach (var adjacent in adjacentList)
                {
                    var v = vertices.First(x => x.Id == adjacent.ToVertex); //no guarantee index will match the vertexId

                    if (!v.IsVisited)
                    {
                        v.IsVisited = true;
                        v.Parent = u;
                        stack.Push(v);
                    }
                }
            }
            return traversalOrder;
        }

        public List<Vertex> TraverseDFS_Recursive(List<Vertex> vertices, Vertex src, int time=0)
        {
            List<Vertex> traversalOrder = new List<Vertex>();
            DFS_VISIT(vertices, src, 0, traversalOrder);
            return traversalOrder;
        }

        private void DFS_VISIT(List<Vertex> vertices, Vertex u, int time, List<Vertex> traversalOrder)
        {
            time = time + 1;
            u.Time = time;
            u.Color = VertexColor.Gray;

            u.IsVisited = true;
            traversalOrder.Add(u);

            foreach (var edge in u.Edges)
            {
                var toVertex = vertices.Single(x => x.Id == edge.ToVertex);
                if (toVertex.Color == VertexColor.White)
                {
                    toVertex.Parent = u;
                    DFS_VISIT(vertices, toVertex, time, traversalOrder);
                }
                if (toVertex.Color == VertexColor.Gray)
                {
                    //cycle
                    toVertex.IsCyclic = true;
                    toVertex.Parent = u;
                }

            }
            u.Color = VertexColor.Black;
            time = time + 1;
            u.FinishedTime = time;
        }

        public void DFSCycleDetection(List<Vertex> graph)
        {
            int time = 0;
            foreach (Vertex u in graph)
            {
                u.Color = VertexColor.White;
                u.Parent = null;
            }

            foreach (Vertex u in graph)
            {
                if (u.Color == VertexColor.White)
                {
                    TraverseDFS_Recursive(graph, u, time);
                }
            }
        }

        public List<string> GetAllCycle(List<Vertex> graph)
        {
            var cycles = graph.Where(x => x.IsCyclic).ToList();
            List<string> result = new List<string>();
            
            foreach (Vertex u in cycles)
            {
                if (u.IsCyclic)
                {
                    var s = "Prinitng Cycle for " + u.Id.ToString() + " : ";
                    var start = u;

                    var parent = u;
                    while (true)
                    {
                        s += "->" + parent.Id.ToString();
                        parent = parent.Parent;
                        
                        if (parent == start)
                            break;
                    }
                    result.Add(s);
                }

                

            }

            return result;
        }


    }

}
