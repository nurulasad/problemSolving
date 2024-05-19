using System;
using System.Linq;

public class MaximalSquareDP
{

    /*
     *  0 0 0 0 
     *  0 1 1 1
     *  1 1 1 1
     *  0 1 1 1
     * 
     * answer is 3 by 3 sqaure
     * https://www.youtube.com/watch?v=6X7Ha2PrDmM&list=PLot-Xpze53lcvx_tjrr_m2lgD2NsRHlNO&index=17
     */

    static int[][] cache;

    private void setCache(int[][] arr)
    {
        cache = new int[arr.Length][];
        for (int i = 0; i < arr.Length; i++)
        {
            cache[i] = new int[arr[i].Length];
        }
    }
    public int MaximalSquare(int[][] matrix, int r, int c)
    {
        if(r == 0 && c == 0)
        {
            setCache(matrix);
        }
        

        if (r >= matrix.GetLength(0) || c >= matrix[0].GetLength(0))
        {
            return 0;
        }

        var down = MaximalSquare(matrix, r + 1, c);
        var right = MaximalSquare(matrix, r, c + 1);
        var diag = MaximalSquare(matrix, r + 1, c + 1);

        if (matrix[r][c] == 1)
        {

            var result = 1 + Math.Min(down, Math.Min(right, diag));
            cache[r][c] = result;

            return cache[r][c];
        }

        return 0;
    }

    public int MS(int[][] matrix, int r, int c)
    {
        var s = MaximalSquare(matrix, r, c);
        var max = -1;

        for (int i = 0; i < cache.Length; i++)
        {
            var p = cache[i].Max();
            if(p > max)
            {
                max = p;
            }

        }
        return max;
    }


}




