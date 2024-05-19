using HackerrankSrc;
using System.Linq;
using Xunit;

namespace HackerrankSrcTest
{
    public class CouponExchangeUnitTest
    {

        [Theory]
        [InlineData(new int[] { 1, 46, 1, 46, 40, 7 }, 47, 2)]
        [InlineData(new int[] { 40, 60, 10, 90, 20, 80, 80, 20, 20, 80 }, 100, 3)]
        [InlineData(new int[] { 40, 60, 10, 90, 20, 80, 80, 20, 20, 80 }, 2500, 0)]
        [InlineData(new int[] { 40 }, 50, 0)]
        public void Test1(int[] input, int sum, int expected)
        {
            var sut = new CouponExchange();
            var actual = sut.NumberOfPayment(input.ToList(), sum);

            Assert.Equal(expected, actual);

            var actual2 = sut.NumberOfPaymentWithHash(input.ToList(), sum);
            Assert.Equal(expected, actual2);

        }
    }
}