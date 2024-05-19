using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class PostfixExpressionEvaluationUnitTest
    {

        [Theory]
        [InlineData("31 4 50 + *", 1674)]
        [InlineData("3 4 +", 7)]
        [InlineData("3 4 *", 12)]
        [InlineData("6 3 /", 2)]
        [InlineData("12 23 + 14 -", 21)]
        [InlineData("2 43 12 * + 12 +", 530)]
        [InlineData("12 3 + 12 3 + * 12 3 + /", 15)]
        [InlineData("32 34 12 * + 1 2 + * 1 1 + / 23 21 - *", 1320)]
        [InlineData("12 10 * 12 /", 10)]
        public void Test1(string input, int expected)
        {
            var sut = new PostfixExpressionEvaluation();
            var actual = sut.PostfixEvaluation(input);

            Assert.Equal(expected, actual);

        }
    }
}