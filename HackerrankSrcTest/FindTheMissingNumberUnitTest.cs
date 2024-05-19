using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class FindTheMissingNumberUnitTest
    {

        [Theory]
        [InlineData(new int[] { 4, 0, 3, 1 }, 2)]
        [InlineData(new int[] { 8, 3, 5, 2, 4, 6, 0, 1 }, 7)]
        public void Test1(int[] input, int expected)
        {
            var sut = new FindTheMissingNumber();
            var actual = sut.GetMissingNumber(input);

            Assert.Equal(expected, actual);

        }
    }
}