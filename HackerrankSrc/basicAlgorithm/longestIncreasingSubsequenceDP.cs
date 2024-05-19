using System;


namespace LongestIncreasingSubsequenceDP {
    class Solution
    {


        /*
         * https://www.interviewbit.com/problems/longest-increasing-subsequence/
         * Find the longest increasing subsequence of a given array of integers, A.

In other words, find a subsequence of array in which the subsequence’s elements are in strictly increasing order, and in which the subsequence is as long as possible. 

This subsequence is not necessarily contiguous, or unique.

In this case, we only care about the length of the longest increasing subsequence.



Input Format:

The first and the only argument is an integer array A.
Output Format:

Return an integer representing the length of the longest increasing subsequence.
Constraints:

1 <= length(A) <= 2500
1 <= A[i] <= 2000
Example :

Input 1:
    A = [1, 2, 1, 5]

Output 1:
    3
    
Explanation 1:
    The sequence : [1, 2, 5]

Input 2:
    A = [0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]
    
Output 2:
    6

Explanation 2:
    The sequence : [0, 2, 6, 9, 13, 15] or [0, 4, 6, 9, 11, 15] or [0, 4, 6, 9, 13, 15]
         */
        public static int LIS(int[] nums)
        {
            int[] lis = new int[nums.Length];
            int max_len = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                lis[i] = 1;
            }
            //for 1 item
            if(nums.Length > 0)
            {
                max_len = lis[0];
            }

            for(int i = nums.Length-1; i >=0; i--)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        lis[i] = Math.Max(lis[i], 1+ lis[j]);
                        if(lis[i] > max_len)
                        {
                            max_len = lis[i];   
                        }
                    }
                }
            }

            return max_len;
        }



        static void Main(string[] args)
        {
            //int[] arr = new int[] { 5, 2};
            int[] arr = new int[] { 1, 2, 4, 3 };
            //int[] arr = new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            Console.WriteLine("Longest Increasing subsequence");

            var result =  LIS(arr);
            Console.WriteLine("Longest Increasing subsequence : "+ result);

            Console.ReadLine();
        }
    }

}


