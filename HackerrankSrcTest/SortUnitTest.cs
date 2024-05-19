using HackerrankSrc;
using Xunit;

namespace HackerrankSrcTest
{
    public class SortUnitTest
    {

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61 })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_BubbleSort(int[] input, int[] expected)
        {
            var sut = new BubbleSort();
            sut.Sort(input);

            Assert.Equal(expected, input);

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61 })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_MergeSort(int[] input, int[] expected)
        {
            var sut = new MergeSort();
            sut.Sort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61 })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_InsertionSort(int[] input, int[] expected)
        {
            var sut = new InsertionSort();
            sut.Sort(input);

            Assert.Equal(expected, input);

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61 })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_SelectionSort(int[] input, int[] expected)
        {
            var sut = new SelectionSort();
            sut.Sort(input);

            Assert.Equal(expected, input);

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61  })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_QuickSort(int[] input, int[] expected)
        {
            var sut = new QuickSort();
            sut.Sort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);

        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { int.MaxValue }, new int[] { int.MaxValue })]
        [InlineData(new int[] { 5, 0 }, new int[] { 0, 5 })]
        [InlineData(new int[] { -100, 50, 0, -60, int.MaxValue }, new int[] { -100, -60, 0, 50, int.MaxValue })]
        [InlineData(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] { 9, 18, 23, 32, 50, 61 })]
        [InlineData(new int[] { 10, 80, 30, 90, 40, 50, 70 }, new int[] { 10, 30, 40, 50, 70, 80, 90 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, 0 }, new int[] { -500, -1, 0, 30, 60, 80, 5000 })]
        [InlineData(new int[] { 5000, 80, 30, 60, -1, -500, -2500, 0 }, new int[] { -2500, -500, -1, 0, 30, 60, 80, 5000 })]
        public void Test_HeapSort(int[] input, int[] expected)
        {
            var sut = new HeapSort();
            sut.Sort(input);

            Assert.Equal(expected, input);

        }
    }
}