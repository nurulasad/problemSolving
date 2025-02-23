﻿using System;

public class BitwiseOperation
{
    //https://stackoverflow.com/questions/141525/what-are-bitwise-shift-bit-shift-operators-and-how-do-they-work
    public int LeftShift(int n, int pos)
    {
        n = n << pos;
        return n;
    }

    public int RightShift(int n, int pos)
    {
        n = n >> pos;
        return n;
    }

    /*
    
5. If we subtract a power of 2 numbers by 1 then all unset bits after the only set bit become set; and the set bit becomes unset.
For example for 4 ( 100) and 16(10000), we get the following after subtracting 1 
3 –> 011 
15 –> 01111

So, if a number n is a power of 2 then bitwise & of n and n-1 will be zero. We can say n is a power of 2 or not based on the value of n&(n-1). The expression n&(n-1) will not work when n is 0. To handle this case also, our expression will become n& (!n&(n-1)) (thanks to https://www.geeksforgeeks.org/program-to-find-whether-a-no-is-power-of-two/Mohammad for adding this case). 

Below is the implementation of this method.  

Time complexity : O(1)

Space complexity : O(1) 
     */
    public bool IsPowerOfTwo(int n)
    {
        if (n == 0) return false;

        n = n & n - 1;
        if (n == 0)
            return true;
        return false;
    }


}
