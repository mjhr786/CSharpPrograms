using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    //Time Complexity: O(n2) as there are two nested loops.
    //Auxiliary Space: O(1)
    //The good thing about selection sort is it never makes more than O(n) swaps and can be useful when memory write is a costly operation.
    // https://www.geeksforgeeks.org/selection-sort/
    // https://www.geeksforgeeks.org/program-to-sort-an-array-of-strings-using-selection-sort/
    partial class Program
    {

        public static void SelctionSortExample()
        {
            int[] arr1 = { 64, 25, 12, 22, 11 };
            SelectionSort(arr1);
            Console.WriteLine("Selection Sorted array");
            printArray(arr1);

            // Sorts an array of strings
            string[] arr = { "GeeksforGeeks",
                     "Practice.GeeksforGeeks",
                     "GeeksQuiz" };
            int n = arr.Length;
            Console.WriteLine("Given array is");

            // Printing the array before sorting
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ": " + arr[i]);
            }
            Console.WriteLine();

            SelectionSort(arr, n);

            Console.WriteLine("Sorted array is");

            // Printing the array after sorting
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ": " + arr[i]);
            }
        }
        // C# program for implementation
        // of Selection Sort
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Sorts an array of strings
        public static void SelectionSort(string[] arr, int n)
        {

            // One by one move boundary of
            // unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {

                // Find the minimum element in
                // unsorted array
                int min_index = i;
                string minStr = arr[i];

                for (int j = i + 1; j < n; j++)
                {

                    /*compareTo() will return a -ve value, 
                    if string1 (arr[j]) is smaller than
                    string2 (minStr)*/
                    // If arr[j] is smaller than minStr

                    if (arr[j].CompareTo(minStr) != 0)
                    {

                        // Make arr[j] as minStr and
                        // update min_idx
                        minStr = arr[j];
                        min_index = j;
                    }
                }

                // Swapping the minimum element 
                // found with the first element.
                if (min_index != i)
                {
                    string temp = arr[min_index];
                    arr[min_index] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
