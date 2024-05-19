using HackerrankSrc;
using System.Linq;
using Xunit;

namespace HackerrankSrcTest
{
    public class MaxDifferenceUnitTest
    {

        [Theory]
        [InlineData(new int[] { 2, 3, 10, 2, 4, 8, 1 }, 8)]
        [InlineData(new int[] { -10, 0, 15, 2 }, 25)]
        [InlineData(new int[] { 5, 5, 5 }, -1)]
        [InlineData(new int[] { 200, 100 }, -1)]

        public void Test1(int[] input, int expected)
        {
            var sut = new MaxDifference();
            var actual = sut.FindMaxDifference(input.ToList());

            Assert.Equal(expected, actual);

        }
    }
}