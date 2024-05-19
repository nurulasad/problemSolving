using System;

namespace HackerrankSrc
{
    public class BubbleSort
    {

        /*
         * Complexity O(n2)
         * Complexity O(n2)
         */
        public void Sort(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {

                        var temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i]);
            }
        }

    }

}
