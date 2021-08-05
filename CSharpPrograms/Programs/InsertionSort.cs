﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    // https://www.geeksforgeeks.org/insertion-sort/
    partial class Program
    {
        public static void InsertionSortExample()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort(arr);
            Console.WriteLine("Insertion Sorted array");
            printArray(arr);
        }
        // Function to sort array
        // using insertion sort
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // A utility function to print
        // array of size n
        static void printInsArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
    }
}
