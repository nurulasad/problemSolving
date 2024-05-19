using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class ConvertIntToExcelTitleLCUnitTest
    {
        [Theory]
        [InlineData(1, "A")]
        [InlineData(3, "C")]
        [InlineData(26, "Z")]
        [InlineData(27, "AA")]
        [InlineData(28, "AB")]
        [InlineData(701, "ZY")]
        [InlineData(2458, "CPN")]
        [InlineData(897645123, "BWNHEJK")]
        public void Test1(int input, string expected)
        {
            var sut = new ConvertIntToExcelTitleLC();
            var actual = sut.ConvertToTitle(input);

            Assert.Equal(expected, actual);

        }

      
    }
}