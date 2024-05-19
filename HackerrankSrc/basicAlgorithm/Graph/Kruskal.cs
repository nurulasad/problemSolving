using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{

    public class Kruskal
    {
        /*https://en.wikipedia.org/wiki/Kruskal%27s_algorithm#Pseudocode
         * 
         * 
            algorithm Kruskal(G) is
                F:= ∅
                for each v ∈ G.V do
                    MAKE-SET(v)
                for each (u, v) in G.E ordered by weight(u, v), increasing do
                    if FIND-SET(u) ≠ FIND-SET(v) then
                        F:= F ∪ {(u, v)} ∪ {(v, u)}
                        UNION(FIND-SET(u), FIND-SET(v))
                return F
         * 
         * 
         * 
         * 
         * 
        */

        public List<Vertex>  KruskalMST(List<Vertex> graph, Vertex root)
        {

            //https://www.geeksforgeeks.org/kruskals-minimum-spanning-tree-algorithm-greedy-algo-2/

            return graph;

        }



    }



}
