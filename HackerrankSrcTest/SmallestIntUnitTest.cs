using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class SmallestIntUnitTest
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { -1, -3  }, 1)]
        [InlineData(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new int[] { 0 }, 1)]      
        [InlineData(new int[] {  }, 1)]      
        public void Test1(int[] input, int expected)
        {
            var sut = new SmallestInt();
            var actual = sut.FindSmallestInt(input);

            Assert.Equal(expected, actual);

        }
    }
}