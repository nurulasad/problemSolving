using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class BinaryGapUnitTest
    {

        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 0)]
        [InlineData(1, 0)]
        [InlineData(5, 1)]
        [InlineData(42048, 3)]
        [InlineData(529, 4)]
        public void Test1(int input, int expected)
        {
            var sut = new BinaryGap();
            var actual = sut.LongestGap(input);

            Assert.Equal(expected, actual);

        }
    }
}