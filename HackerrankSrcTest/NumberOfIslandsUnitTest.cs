using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class NumberOfIslandsUnitTest
    {

        /*
         * 000000
         * 011110
         * 010010
         * 011110
         * 000000
         * 
         * 
         * 0101
         * 1010
         * 0101
         */
        [Theory]
        [InlineData(new string[] { "" }, 0)]
        [InlineData(new string[] { "1" }, 1)]
        [InlineData(new string[] { "101", "010" }, 3)]
        [InlineData(new string[] { "0000", "0100", "0000" }, 1)]
        [InlineData(new string[] { "110000", "011000", "001100", "000110", "000011" }, 1)]
        [InlineData(new string[] { "000000", "011110", "010010", "011110", "000000" }, 1)]
        [InlineData(new string[] { "000000" }, 0)]
        [InlineData(new string[] { "111111" }, 1)]
        [InlineData(new string[] { "100001" }, 2)]
        [InlineData(new string[] { "1111", "1001", "1111" }, 1)]

        public void Test1(string[] s, int expected)
        {
            var sut = new NumberOfIslands();
            var input = GetArrayFromSring(s);
            Assert.Equal(expected, sut.CountNumberOfIslands(input));
        }

        private int[][] GetArrayFromSring(string[] s)
        {

            if (s.Length == 0)
                return new int[0][];


            var rows = s.Length;
            int[][] m = new int[s.Length][];

            var row = 0;
            foreach (var item in s)
            {
                var cols = item.Length;
                m[row] = new int[cols];

                for (int col = 0; col < item.Length; col++)
                {
                    m[row][col] = int.Parse("" + item[col]);
                }
                row++;
            }
            return m;

        }
    }
}