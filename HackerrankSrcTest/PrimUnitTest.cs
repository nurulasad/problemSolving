using HackerrankSrc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HackerrankSrcTest
{
    public class PrimUnitTest
    {

        [Fact]
        public void Test1()
        {

            Vertex v1 = new Vertex(1, new List<int> { 2, 4 });
            Vertex v2 = new Vertex(2, new List<int> { 1, 3, 4, 5 });
            Vertex v3 = new Vertex(3, new List<int> { 2, 4, 5 });
            Vertex v4 = new Vertex(4, new List<int>() { 1, 2 , 3});
            Vertex v5 = new Vertex(5, new List<int> { 2, 3 });
            

            var graph = new List<Vertex>() { v1, v2, v3, v4, v5 };
            var sut = new Prim();
            var actual = sut.PrimMST(graph, v1);


            Assert.Equal(0, actual[2].Edges.Count);
            Assert.Equal(0, actual[3].Edges.Count);

        }

        [Fact]
        public void Test2()
        {

            Vertex v1 = new Vertex(1, new List<Edge>() { new Edge(2, 1), new Edge(3, 10), new Edge(4, 20) });
            Vertex v2 = new Vertex(2, new List<Edge>() { new Edge(3, 2) });
            Vertex v3 = new Vertex(3, new List<Edge>() { new Edge(4, 3) });
            Vertex v4 = new Vertex(4);
           
            

            var graph = new List<Vertex>() { v1, v2, v3, v4 };
            var sut = new Prim();
            var actual = sut.PrimMST(graph, v1);


            //is the actual correct ?
        }


    }
}