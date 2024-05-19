﻿using System;

namespace HackerrankSrc {
    public class MergeSort
    {
        //https://www.geeksforgeeks.org/merge-sort/
        // Runtime O(N log(N))

        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = left + (right - left) / 2;

                // Sort first and second halves
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        private void Merge(int[] arr, int left, int middle, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[middle + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        

    }
}



