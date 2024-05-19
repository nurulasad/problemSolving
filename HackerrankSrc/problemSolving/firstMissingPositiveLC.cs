

using System.Collections.Generic;
using System.Linq;

public class FirstMissingPositiveNumber
{

    //https://leetcode.com/problems/first-missing-positive/
    //solved, running it in O(n) is the main challenge here


    public int FirstMissingPositive(int[] nums)
    {
        long size = nums.Max();

        if (size <= 0)
            return 1;

        Dictionary<int, int> check = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 1)
                continue;
            
            if (!check.ContainsKey(nums[i]))
            {
                check.Add(nums[i], 1);
            }
        }

        for (int i = 1; i <= size; i++)
        {
            if (!check.ContainsKey(i))
            {
                return i;
            }
        }

        return (int) (size+1);

    }


   



}
