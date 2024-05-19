using System;


namespace HackerrankSrc
{
    public class HeapSort
    {

        /*
         * https://www.geeksforgeeks.org/heap-sort/
         * 
         * public void sort(int[] arr)
    {
        int N = arr.Length;
 
        // Build heap (rearrange array)
        for (int i = N / 2 - 1; i >= 0; i--)
            heapify(arr, N, i);
 
        // One by one extract an element from heap
        for (int i = N - 1; i > 0; i--) {
            // Move current root to end
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
 
            // call max heapify on the reduced heap
            heapify(arr, i, 0);
        }
    }
         */
        public void Sort(int[] nums)
        {
            var root = InsertLevelOrder(nums, 0);

            MinHeapify(root);

            //var arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = root.val;
                var leaf = GetLeafNode(root);
                
                root.val = leaf.val;

                leaf.val = int.MinValue;
                DeleteLeafNode(root,leaf.val);

                MinHeapify(root);

            }



        }


        private TreeNode DeleteLeafNode(TreeNode root, int value)
        {
            if (root == null)
                return null;
            root.left = DeleteLeafNode(root.left, value);
            root.right = DeleteLeafNode(root.right, value);

            if (root.val == value &&
                root.left == null &&
                root.right == null)
            {

                return null;
            }
            return root;
        }


        public TreeNode GetLeafNode(TreeNode root)
        {

            // If node is null, return
            if (root == null)
                return root;

            // If node is leaf node, print its data    
            if (root.left == null &&
                root.right == null)
            {
                return root; ;
            }

            // If left child exists, check for leaf
            // recursively
            if (root.left != null)
                root = GetLeafNode(root.left);

            // If right child exists, check for leaf
            // recursively
            if (root.right != null)
                root = GetLeafNode(root.right);

            return root;

        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap

        /*
         * int largest = i; // Initialize largest as root
        int l = 2 * i + 1; // left = 2*i + 1
        int r = 2 * i + 2; // right = 2*i + 2
 
        // If left child is larger than root
        if (l < N && arr[l] > arr[largest])
            largest = l;
 
        // If right child is larger than largest so far
        if (r < N && arr[r] > arr[largest])
            largest = r;
 
        // If largest is not root
        if (largest != i) {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
 
            // Recursively heapify the affected sub-tree
            heapify(arr, N, largest);
        }
         */

        public void MinHeapify(TreeNode root)
        {
            //something is incorrect here , it can not MinHeapify correctly for one input set
            TreeNode smallest = root;

          
            if (root.left != null && root.left.val < smallest.val)
            {
                smallest = root.left;
            }
            if (root.right != null && root.right.val < smallest.val)
            {
                smallest = root.right;
            }

            // If smallest is not root
            if (smallest != root)
            {

                int temp = root.val;
                root.val = smallest.val;
                smallest.val = temp;


                // Recursively heapify the affected sub-tree
                MinHeapify(smallest);
            }


        }


        /* Function to insert nodes in level order
         * https://www.geeksforgeeks.org/construct-complete-binary-tree-given-array/
         */
        public TreeNode InsertLevelOrder(int[] input, int i)
        {
            TreeNode root = null;
            // Base case for recursion
            if (i < input.Length)
            {
                root = new TreeNode(input[i]);

                root.left = InsertLevelOrder(input, 2 * i + 1);
                root.right = InsertLevelOrder(input, 2 * i + 2);
            }
            return root;
        }


    }

}
