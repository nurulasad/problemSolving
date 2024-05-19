using System.Collections.Generic;
using System.Linq;

class Solution
{
    /*
     * You are given N coupons with some values 
     * Need to make a sum of K with exactly two coupons, with non repeating coupons
     * Return number ways 
     * Example:
     * Coupons = {1,46, 1, 46, 40, 7}, sum = 47
     * 
     * result = 2 
     * Explanation : 
     * 1+46 = 47, 40+7 = 47
     * (Multipel 1 and 46 but will be counted once)
     * 
     */ 
    static int couponChange(List<int> coupons, int sum)
    {
        int[,] sol = new int[coupons.Count, coupons.Count];
        List<List<int>> usedCoupons = new List<List<int>>();

        int count = 0;
        for (int i = 0; i < coupons.Count; i++)
        {
            for (int j = 1; j < coupons.Count; j++)
            {
                if (coupons[i] + coupons[j] == sum)
                {
                    if (sol[j, i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (usedCoupons.Any(x =>
                         (x[0] == coupons[i] && x[1] == coupons[j])
                         ||
                         (x[0] == coupons[j] && x[1] == coupons[i])
                        ))
                        {
                            continue;
                        }
                        else
                        {
                            count++;
                            usedCoupons.Add(new List<int>() { coupons[i], coupons[j] });
                            sol[i, j] = 1;
                        }
                        
                    }

                }

            }

        }

        return count;


    }



    static void Main(string[] args)
    {


        List<int> coupons = new List<int>() { 1, 46, 1, 46, 40, 7 };


        int result = couponChange(coupons, 47);


    }
}
