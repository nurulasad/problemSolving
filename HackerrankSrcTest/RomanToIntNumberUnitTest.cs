using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class RomanToIntNumberUnitTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("IV", 4)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        
        public void Test2(string input, int expected)
        {
            var sut = new RomanToIntNumber();
            var actual = sut.RomanToInt(input);
            Assert.Equal(expected, actual);
        }

    }
}