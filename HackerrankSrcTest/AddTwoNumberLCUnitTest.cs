using Xunit;

namespace HackerrankSrcTest
{
    public class AddTwoNumberLCUnitTest
    {

        [Fact]

        public void Test1()
        {
            var sut = new AddTwoNumberLC();

            var num1 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var num2 = new ListNode(2, new ListNode(4, new ListNode(3)));

            var sum = sut.AddTwoNumbers(num1, num2);
            var actual = sut.ToNumber(sum);

            
            Assert.Equal(708,actual);

        }

        [Fact]
        public void Test2()
        {
            var sut = new AddTwoNumberLC();

            var num1 = new ListNode(9, new ListNode(9, new ListNode(9)));
            var num2 = new ListNode(8, new ListNode(8, new ListNode(8)));

            var sum = sut.AddTwoNumbers(num1, num2);
            var actual = sut.ToNumber(sum);


            Assert.Equal(7881, actual);

        }


    }
}