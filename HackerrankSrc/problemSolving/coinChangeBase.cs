using System;

public class Solution
{

    static long getNumberOfWays(long N, long[] coins)
    {
        long[] ways = new long[(int)N + 1];

        // Set the first way to 1 because its 0 and 
        // there is 1 way to make 0 with 0 coins 
        ways[0] = 1;
 
        for (int i = 0; i < coins.Length; i++)
        {
        
 
            for (int j = 0; j < ways.Length; j++)
            {
                if (coins[i] <= j)
                {
                   
                    ways[j] += ways[(int)(j - coins[i])];
                }
            }
        }

        return ways[(int)N];
    }

    static void printArray(long[] coins)
    {
        foreach (long i in coins)
            Console.WriteLine(i);
    }

    // Driver code 
    public static void Main(String[] args)
    {
        long[] Coins = { 1, 2, 3 };

        Console.WriteLine("The Coins Array:");
        printArray(Coins);

        Console.WriteLine("Solution:");

        long res = getNumberOfWays(4, Coins);
        int a = 0;
    }
}

// This code has been contributed by 29AjayKumar 
