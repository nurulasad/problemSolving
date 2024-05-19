using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class PeakElementUnitTest
    {
    



        [Theory]
        [InlineData(new int[] { 1,2,3,1,0}, 2)]
        [InlineData(new int[] { 1,2,3}, 2)]
        public void Test2(int[] input, int expected)
        {
            var sut = new PeakElement();
            var actual = sut.FindPeakElement(input);
            Assert.Equal(expected, actual);
        }

    }
}