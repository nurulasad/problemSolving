using HackerrankSrc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HackerrankSrcTest
{
    public class FindNumberOfParentsUnitTest
    {

        [Fact]

        public void Test1()
        {
            var sut = new FindNumberOfParents();

            var pairs = new List<int[]>() {
            new int[]{5, 6},
            new int[]{1, 3},
            new int[]{2, 3},
            new int[]{3, 6},
            new int[]{15, 12},
            new int[]{5, 7},
            new int[]{4, 5},
            new int[]{4, 9},
            new int[]{9, 12},
            new int[]{30, 16}
        };

            var actual = sut.ParentCount(pairs);
            var actualOneParent = actual[0];
            var expectedOneParent = new List<int>() { 5, 7, 9, 16 };

            Assert.True(!expectedOneParent.Except(actualOneParent).Any() && expectedOneParent.Count == actualOneParent.Count);

            var actualNoParent = actual[1];
            var expectedNoParent = new List<int>() { 1, 2, 4, 15, 30 };

            Assert.True(!expectedNoParent.Except(actualNoParent).Any() && expectedNoParent.Count == actualNoParent.Count);

        }

        [Fact]
        public void Test2()
        {
            var sut = new FindNumberOfParents();

            var pairs = new List<int[]>() {
            new int[]{1, 2},
            new int[]{2, 3},
            new int[]{3, 4},
            new int[]{10, 11},
            new int[]{11, 12}
            };

            var actual = sut.ParentCount(pairs);
            var actualOneParent = actual[0];
            var expectedOneParent = new List<int>() { 2, 3, 4, 11, 12 };

            Assert.True(!expectedOneParent.Except(actualOneParent).Any() && expectedOneParent.Count == actualOneParent.Count);

            var actualNoParent = actual[1];
            var expectedNoParent = new List<int>() { 1, 10 };

            Assert.True(!expectedNoParent.Except(actualNoParent).Any() && expectedNoParent.Count == actualNoParent.Count);

        }

        [Fact]
        public void Test3()
        {
            var sut = new FindNumberOfParents();

            var pairs = new List<int[]>() {
            new int[]{1, 2},
            new int[]{2, 3},
            new int[]{3, 4},
            new int[]{10, 11},
            new int[]{11, 12},
            new int[]{1, 11},
            new int[]{2, 12},
            new int[]{3, 12},
            new int[]{12, 4}
            };

            var actual = sut.ParentCount(pairs);
            var actualOneParent = actual[0];
            var expectedOneParent = new List<int>() { 2, 3 };

            Assert.True(!expectedOneParent.Except(actualOneParent).Any() && expectedOneParent.Count == actualOneParent.Count);

            var actualNoParent = actual[1];
            var expectedNoParent = new List<int>() { 1, 10 };

            Assert.True(!expectedNoParent.Except(actualNoParent).Any() && expectedNoParent.Count == actualNoParent.Count);

        }
    }
}