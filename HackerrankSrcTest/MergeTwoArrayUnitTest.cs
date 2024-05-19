using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class MergeTwoArrayUnitTest
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 1,1,2, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 2, 5, 6 }, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, new int[] {  }, new int[] { 1 })]
        public void Test1(int[] nums1, int[] nums2, int[] expected)
        {
            var sut = new MergeTwoArray();
            var actual = sut.Merge(nums1, nums2);

            Assert.Equal(expected, actual);

        }
    }
}
