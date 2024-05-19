using System;


namespace HackerrankSrc
{
    public class SelectionSort
    {

        /*
         * Complexity O(n2)- same as bubble sort
         */
        public void Sort(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //swap
                var temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i]);
            }
        }

    }

}
