using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class CheckBalancedParenthesisExpressionUnitTest
    {

        [Theory]
        [InlineData("", true)]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("{()}", true)]
        [InlineData("){()}", false)]
        [InlineData("{()})", false)]
        [InlineData("{()}(", false)]
        [InlineData("(()({}[{}]))", true)]
        [InlineData("(()({}[{}]))[", false)]
        
        public void Test1(string input, bool expected)
        {
            var sut = new CheckBalancedParenthesisExpression();
            var actual = sut.CheckBalanced(input);

            Assert.Equal(expected, actual);

        }
    }
}