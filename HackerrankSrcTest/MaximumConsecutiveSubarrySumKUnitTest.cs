using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class MaximumConsecutiveSubarrySumKUnitTest
    {

        [Theory]
        [InlineData(3, new int[] { 2, 1, 5, 1, 3, 2 }, 9)]
        [InlineData(2, new int[] { 2, 3, 4, 1, 5 }, 7)]
        [InlineData(1, new int[] { 1 }, 1)]
        [InlineData(1, new int[] { 1,10,11 }, 11)]
        [InlineData(5, new int[] { 1,2,3,4,5 }, 15)]
        [InlineData(3, new int[] { 1,2,3,4,5 }, 12)]
        
        public void Test1(int length, int[] nums, int expected)
        {
            var sut = new MaximumConsecutiveSubarrySumK();
            var actual = sut.SubarrySum(length, nums);

            Assert.Equal(expected, actual);

        }
    }
}