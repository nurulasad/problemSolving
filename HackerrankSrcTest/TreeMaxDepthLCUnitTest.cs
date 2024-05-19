using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class TreeMaxDepthLCUnitTest
    {

        [Fact]
      
        public void Test1()
        {
            var sut = new TreeMaxDepthLC();

            var input = new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4))), new TreeNode(20));
            var actual = sut.MaxDepth(input);

            Assert.Equal(4, actual);

        }
    }
}