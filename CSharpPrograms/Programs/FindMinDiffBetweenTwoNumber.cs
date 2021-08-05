using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    partial class Program
    {
        // Returns minimum difference between any pair
        //Simple: O(n2) 
        public static int findMinDiff(int[] arr, int n)
        {

            // Initialize difference as infinite
            int diff = int.MaxValue;

            // Find the min diff by comparing difference
            // of all possible pairs in given array
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (Math.Abs((arr[i] - arr[j])) < diff)
                        diff = Math.Abs((arr[i] - arr[j]));

            // Return min diff
            return diff;
        }

        // Returns minimum difference
        // between any pair
        // Efficient: O(n Log n) 
        public static int findMinDiffNew(int[] arr,
                               int n)
        {
            // Sort array in
            // non-decreasing order
            Array.Sort(arr);

            // Initialize difference
            // as infinite
            int diff = int.MaxValue;

            // Find the min diff by
            // comparing adjacent pairs
            // in sorted array
            for (int i = 0; i < n - 1; i++)
                if (arr[i + 1] - arr[i] < diff)
                    diff = arr[i + 1] - arr[i];

            // Return min diff
            return diff;
        }
    }
}
