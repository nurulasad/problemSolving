using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSubArraKadane
{

    public class MaximumSubArrayKadane
    {
       
        public static int MaxSumSubArray(int[] a)
        {
            int localMax = 0;
            int globalMax = int.MinValue;

            for(int i = 0; i < a.Length; i++)
            {
                localMax = Math.Max(a[i], a[i]+localMax);
                {
                    if(localMax > globalMax)
                    {
                        globalMax = localMax;
                    }
                }
            }
            return globalMax;
        } 

        static void Main(string[] args)
        {
            int[] input = new int[] { -2, 1, -3, 4, 1, 2, 1, -5, 4 };

            var max = MaxSumSubArray(input);

            Console.WriteLine("Max Sum = " + max);
            Console.ReadLine();

        }
    }

    
}
