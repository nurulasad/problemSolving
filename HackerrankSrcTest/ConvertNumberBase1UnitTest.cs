using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class ConvertNumberBase1UnitTest
    {

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "3")]
        [InlineData(10, "A")]
        [InlineData(11, "B")]
        [InlineData(15, "F")]
        [InlineData(16, "10")]
        [InlineData(17, "11")]
        public void Test1(int input, string expected)
        {
            var sut = new ConvertNumberBase1();
            var actual = sut.ConvertHex(input);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "3")]
        [InlineData(26, "10")]
        [InlineData(27, "11")]
        [InlineData(28, "12")]
        [InlineData(701, "10P")]
        public void Test2(int input, string expected)
        {
            var sut = new ConvertNumberBase1();
            var actual = sut.ConvertBase26(input);

            Assert.Equal(expected, actual);

        }
    }
}