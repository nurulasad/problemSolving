using HackerrankSrc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HackerrankSrcTest
{
    public class GraphTravesrsalUnitTest
    {

        [Fact]
        public void Test1()
        {

            Vertex v1 = new Vertex(1, new List<int> { 2 });
            Vertex v2 = new Vertex(2, new List<int> { 3, 10, 30 });
            Vertex v3 = new Vertex(3, new List<int> { 4, 30 });
            Vertex v4 = new Vertex(4, new List<int>());
            Vertex v5 = new Vertex(10, new List<int> { 20, 30 });
            Vertex v6 = new Vertex(20, new List<int>());
            Vertex v7 = new Vertex(30, new List<int>());

            var graph = new List<Vertex>() { v1, v2, v3, v4, v5, v6, v7 };
            var sut = new GraphTravesrsal();
            var traversalOrder = sut.TraverseBFS(graph, v1);

            var travelOrder = traversalOrder.Select(x => x.Id).ToArray();
            var expected = new int[] { 1, 2, 3, 10, 30, 4, 20 };

            Assert.Equal(expected, travelOrder);

        }


        [Fact]
        public void Test2()
        {
            Vertex v1 = new Vertex(1, new List<int> { 2 });
            Vertex v2 = new Vertex(2, new List<int> { 3, 10, 30 });
            Vertex v3 = new Vertex(3, new List<int> { 4, 30 });
            Vertex v4 = new Vertex(4, new List<int>());
            Vertex v5 = new Vertex(10, new List<int> { 20, 30 });
            Vertex v6 = new Vertex(20, new List<int>());
            Vertex v7 = new Vertex(30, new List<int>());

            var graph = new List<Vertex>() { v1, v2, v3, v4, v5, v6, v7 };

            var sut = new GraphTravesrsal();
            var traversalOrder = sut.TraverseDFS_Recursive(graph, v1);

            var travelOrder = traversalOrder.Select(x => x.Id).ToArray();
            var expected = new int[] { 1, 2, 3, 4, 30, 10, 20 };

            Assert.Equal(expected, travelOrder);


            //
            sut.Initialize(graph);
            var traversalOrder2 = sut.TraverseDFS_Iterative(graph, v1);

            var travelOrder2 = traversalOrder2.Select(x => x.Id).ToArray();
            var expected2 = new int[] { 1, 2, 30, 10, 20, 3, 4 };

            Assert.Equal(expected2, travelOrder2);

        }

        [Fact]
        public void Test3()
        {

            Vertex v1 = new Vertex(1, new List<Edge>() { new Edge(2, 7), new Edge(3, 9), new Edge(6, 14) });
            Vertex v2 = new Vertex(2, new List<Edge>() { new Edge(1, 7), new Edge(3, 10), new Edge(4, 15) });
            Vertex v3 = new Vertex(3, new List<Edge>() { new Edge(1, 9), new Edge(2, 10), new Edge(6, 2), new Edge(4, 11) });
            Vertex v4 = new Vertex(4, new List<Edge>() { new Edge(2, 15), new Edge(3, 11), new Edge(5, 6) });
            Vertex v5 = new Vertex(5, new List<Edge>() { new Edge(6, 9), new Edge(4, 6) });
            Vertex v6 = new Vertex(6, new List<Edge>() { new Edge(1, 14), new Edge(3, 2), new Edge(5, 9) });


            var graph = new List<Vertex>() { v1, v2, v3, v4, v5, v6 };

            var sut = new Dijkstra();
            sut.FindMinimumCost(graph.ToArray(), v1);

            Assert.Equal(20, graph[4].Cost);
            Assert.Equal(20, graph[3].Cost);

        }


        [Fact]
        public void Test4_cycle()
        {

            Vertex v1 = new Vertex(1, new List<int>() { 2, });
            Vertex v2 = new Vertex(2);

            Vertex v3 = new Vertex(3, new List<int>() { 4, 5, 6 });
            Vertex v4 = new Vertex(4, new List<int>() { 5 });
            Vertex v5 = new Vertex(5, new List<int>() { 6 });
            Vertex v6 = new Vertex(6, new List<int>() { 4 });

            Vertex v7 = new Vertex(7, new List<int>() { 8 });
            Vertex v8 = new Vertex(8, new List<int>() { 9 });
            Vertex v9 = new Vertex(9, new List<int>() { 10 });
            Vertex v10 = new Vertex(10, new List<int>() { 7 });

            Vertex v11 = new Vertex(11, new List<int>() { 12 });
            Vertex v12 = new Vertex(12, new List<int>() { 13 });
            Vertex v13 = new Vertex(13, new List<int>() { 12 });

            var graph = new List<Vertex>() { v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13 };

            var sut = new GraphTravesrsal();
            sut.DFSCycleDetection(graph);
            
            var actual = sut.GetAllCycle(graph);

            Assert.Contains("Prinitng Cycle for 4 : ->4->6->5", actual);
            Assert.Contains("Prinitng Cycle for 12 : ->12->13", actual);
            Assert.Contains("Prinitng Cycle for 7 : ->7->10->9->8", actual);

            





        }
    }
}