using System.Collections.Generic;
using System.Linq;

namespace HackerrankSrc
{
    public class TreeMaxDepthLC
    {

        //https://leetcode.com/problems/maximum-depth-of-binary-tree


        

        public int MaxDepth(TreeNode root)
        {
            return Depth(root, 0);
        }

        private int Depth(TreeNode node, int level)
        {
            if (node == null)
                return level;

            return Max(Depth(node.left, level + 1), Depth(node.right, level + 1));
        }

        private int Max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
    }
}