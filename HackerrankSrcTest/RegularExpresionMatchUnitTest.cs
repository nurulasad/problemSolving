using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class RegularExpresionMatchUnitTest
    {

        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("ab", ".*", true)]
        [InlineData("aaabbbccc", ".*", true)]
        [InlineData("aaabbbccc", "a*b*.*", true)]
        [InlineData("aaabbbccc", "a*b*c*", true)]
        [InlineData("aaabbbccc", "a*b*c*d", false)]
        [InlineData("abc", "abcd", false)]
       
        public void Test1(string input, string pattern, bool expected)
        {
            var sut = new RegularExpresionMatch();
            var actual = sut.IsMatch(input,pattern);

            Assert.Equal(expected, actual);

        }
    }
}