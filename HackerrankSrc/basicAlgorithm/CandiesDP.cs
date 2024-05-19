using System;
using System.Collections.Generic;

namespace LongestIncreasingSubsequenceDP
{
    class Solution
    {



        /*
      * Complete the 'candies' function below.
      *
      * The function is expected to return a LONG_INTEGER.
      * The function accepts following parameters:
      *  1. INTEGER n
      *  2. INTEGER_ARRAY arr
      */

        public static LinkedListNode<int> insertNodeAtPosition(LinkedListNode<int> llist, int data, int position)
        {
            var prev = llist;
            for (int i = 0; i < position; i++)
            {
                prev = llist;
                llist = llist.Next;
            }

            var temp = llist.Next;
            LinkedListNode<int> d = new LinkedListNode<int>(data);
            d.Next = d;

            prev.Next = d;
            d.Next = temp;
        }



        static void Main(string[] args)
        {
            //List<int> arr = new List<int> { 4,6,4,5,6,2 };

            List<int> arr = new List<int> { 2, 4, 2, 6, 1, 7, 8, 9, 2, 1 };

            var result = candies(4, arr);
            Console.WriteLine("candies : " + result);

            Console.ReadLine();
        }
    }

}


